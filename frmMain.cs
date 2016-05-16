using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace AvistaBilling
{
    public partial class frmMain : Form
    {
        private string appFolder;
        private string appDataPath;
        private static readonly string mAppDataFilename = "appData.gz";
        private string appDataFullFilename;

        public static ApplicationData AppData { get; set; }

        public frmMain()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            AppData = new ApplicationData();

            appFolder = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), appFolder);

            // Create the application data directory if it does not already exist.
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            appDataFullFilename = Path.Combine(appDataPath, mAppDataFilename);

            // If application data exists, read the compressed data file.
            if (File.Exists(appDataFullFilename))
            {
                try
                {
                    string appDataJason = decompressedFile(appDataFullFilename);
                    AppData = JsonConvert.DeserializeObject<ApplicationData>(appDataJason);
                    AppData.RateSchedules.sort();

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                    System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
                }

            }
        }

        #region Read and write compressed application data file
        private void saveAppData()
        {
            try
            {
                string appDataJASON = JsonConvert.SerializeObject(AppData);
                writeCompressedFile(appDataFullFilename, appDataJASON);
                //File.WriteAllText(appDataFullFilename, appDataJASON);

                if (File.Exists(appDataFullFilename))
                {
                    System.IO.FileInfo info = new System.IO.FileInfo(appDataFullFilename);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("File: " + mAppDataFilename + " successfully saved.").AppendLine();
                    sb.Append("File size: ").Append(info.Length.ToString("###,###,###,###,###")).Append(" bytes.").AppendLine();
                    sb.Append("Modified date: ").Append(info.LastWriteTime.ToString("G")).AppendLine().AppendLine();
                    sb.Append("Number of accounts: ").Append(AppData.Accounts.Count).AppendLine();
                    sb.Append("Number of rate schedules: ").Append(AppData.RateSchedules.Count).AppendLine();
                    sb.Append("Number of invoices: ").Append(AppData.Invoices.Count);
                    MessageBox.Show(sb.ToString(), "Application Data Saved");
                }
                else
                {
                    MessageBox.Show("Failed to save " + mAppDataFilename + "!", "Application Data Saved");
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }
        }

        private void writeCompressedFile(string fullFilename, string appDataJASON)
        {

            try
            {
                if (File.Exists(fullFilename))
                {
                    File.Delete(fullFilename);
                }

                UnicodeEncoding uniEncode = new UnicodeEncoding();
                byte[] bytesToCompress = uniEncode.GetBytes(appDataJASON);
                byte[] compress = this.compress(bytesToCompress);
                File.WriteAllBytes(fullFilename, compress);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }

        }

        private byte[] compress(byte[] bytesToCompress)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true))
                {
                    gzip.Write(bytesToCompress, 0, bytesToCompress.Length);
                }
                return memory.ToArray();
            }
        }

        private string decompressedFile(string fullFilename)
        {

            string result = "";
            try
            {
                // Open a compressed file on disk.
                // ... Then decompress it with the method below.
                // ... Then write the length of each array.
                byte[] file = File.ReadAllBytes(fullFilename);
                byte[] decompressed = decompress(file);
                UnicodeEncoding uniEncode = new UnicodeEncoding();
                result = uniEncode.GetString(decompressed);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }
            return result;
        }

        private byte[] decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }
        #endregion

        #region Event handlers

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open clicked.");
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merge clicked.");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAppData();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SaveAS clicked.");
        }


        private void rateSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRateSchedule newRateSchedule = new frmRateSchedule();
            newRateSchedule.Show();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts newFrmAccounts = new frmAccounts();
            newFrmAccounts.Show();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Invoices clicked.");
            frmInvoices newFrmInvoices = new frmInvoices();
            newFrmInvoices.Show();
        }
        #endregion


    }
}
