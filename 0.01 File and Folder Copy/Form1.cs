using System;
using Delimon.Win32.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace _0._01_File_and_Folder_Copy
{
    public partial class MAIN_WINDOW : Form
    {
        #region defaults

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MAIN_WINDOW()
        {
            InitializeComponent();
            TEXT_BOX_OUTPUT.ScrollBars = ScrollBars.Vertical;
            
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(Timer_Tick);
        }

        private void BUTTON_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUTTON_MINIMISE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void MoveForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TEXT_BOX_OUTPUT.Invoke(new Action(() =>
                ReleaseCapture()
            ));

            TEXT_BOX_OUTPUT.Invoke(new Action(() =>
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            ));
        }

        #endregion

        private Timer _timer;

        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        private bool _timerRunning = false;
        private string root = "";
        private string destination = "";

        int totalFiles = 0;

        private void BUTTON_COPY_FROM_Click(object sender, EventArgs e)
        {
            TEXT_BOX_COPY_FROM.Focus();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            // set root as This PC
            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TEXT_BOX_COPY_FROM.Text = dialog.FileName;
                TEXT_BOX_COPY_FROM.SelectionStart = TEXT_BOX_COPY_FROM.Text.Length;
            }
        }

        private void BUTTON_COPY_TO_Click(object sender, EventArgs e)
        {
            TEXT_BOX_COPY_TO.Focus();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            // set root as This PC
            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TEXT_BOX_COPY_TO.Text = dialog.FileName;
                TEXT_BOX_COPY_TO.SelectionStart = TEXT_BOX_COPY_TO.Text.Length;
            }
        }

        private void BUTTON_BEGIN_COPY_Click(object sender, EventArgs e)
        {
            root = TEXT_BOX_COPY_FROM.Text;
            destination = TEXT_BOX_COPY_TO.Text;

            if (string.IsNullOrWhiteSpace(root) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("To begin the copy, please enter a root directory, and a destination directory.");
                return;
            }

            if (!Directory.Exists(root))
            {
                MessageBox.Show("Root directory does not exist.");
                return;
            }

            if (!Directory.Exists(destination))
            {
                MessageBox.Show("Destination directory does not exist.");
                return;
            }

            TEXT_BOX_OUTPUT.Clear();

            MessageBox.Show("During copy, this window will become unresponsive, and the elements will not be interactable.\n" +
                "The copy cannot be stopped once it has been started.");

            Copy();
        }
        
        private void Copy()
        {
            totalFiles = 0;           

            WriteToOutput("copying from the folder " + root);
            WriteToOutput("copying to the folder " + destination);

            
            WriteToOutput("utilizing mutlithreading, spawning as many threads as possible...");
            WriteToOutput("replicating folder structure first");

            try
            {
                foreach (string dirPath in Directory.GetDirectories(root, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        if (Directory.Exists(dirPath.Replace(root, destination)))
                        {                               
                            WriteToOutput("skipping over, folder already exists '" + dirPath.Replace(root, destination) + "'");
                        }
                        else
                        {
                            Directory.CreateDirectory(dirPath.Replace(root, destination));
                            WriteToOutput("created new folder '" + dirPath.Replace(root, destination) + "'");
                        }
                    }
                    catch (Exception e)
                    {
                        WriteToOutput(e.Message);
                    }
                };

                WriteToOutput("finished replicating folder structure, now recreating files");

                
                foreach(string newPath in Directory.GetFiles(root, "*.*", SearchOption.AllDirectories))
                {
                    try
                    {
                        if (CHECKBOX_OVERWRITE.Checked)
                        {
                            File.Copy(newPath, newPath.Replace(root, destination), true);
                            WriteToOutput("recreated the file '" + newPath.Replace(root, destination) + "'");
                        }
                        else
                        {
                            File.Copy(newPath, newPath.Replace(root, destination), false);
                            WriteToOutput("recreated the file '" + newPath.Replace(root, destination) + "'"); 
                        }

                    }
                    catch (Exception e)
                    {
                        WriteToOutput("skipping over, file already exists '" + newPath.Replace(root, destination) + "'");
                    }

                    totalFiles += 1;
                };

                WriteToOutput("completed process, closing threads...");
                LABEL_FILES_COPIED.Text = totalFiles.ToString();
                WriteToOutput("threads closed");
            }

            catch (Exception e)
            {
                WriteToOutput(e.Message);
            }
        }
        
        private void WriteToOutput(string output)
        {
            string text = TEXT_BOX_OUTPUT.Text + "[" + DateTime.Now + "] " + output;

            TEXT_BOX_OUTPUT.Invoke(new Action(() =>
                TEXT_BOX_OUTPUT.AppendText("[" + DateTime.Now + "] " + output + "\n\n")
            ));

            TEXT_BOX_OUTPUT.SelectionStart = TEXT_BOX_OUTPUT.Text.Length - TEXT_BOX_OUTPUT.Text.Length;
            //TEXT_BOX_OUTPUT.AppendText("[" + DateTime.Now + "] " + output + "\n\n");
        }

        private void LABEL_ABOUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application allows Long File Names by default.\n" +
                "This application utilizes optionally multithreading; it will use equal parts memory and CPU to enumerate files and folders quicker.\n" +
                "Since it is disk intensive, CPU and memory should remain minimal at no more than 50% usage.\n" +
                "If you worry about the window being totally unresponsive, this is due to a thread collision and is not related to the copying process. The window will be " +
                "accessible again once the copy has finished.\n" +
                "It was created by Kieran Maher, for internal use at IT Group UK Ltd.");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            // The current elapsed time is the time since the start button
            // was clicked, plus the total time elapsed since the last reset
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            // These are just two Label controls which dis


            LABEL_FILES_COPIED.Text = totalFiles.ToString();
            
            //_currentElapsedTimeDisplay.Text = timeSinceStartTime.ToString();
        }
    }

    public class OnetsButton : Button
    {
        public OnetsButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }
    }

}
