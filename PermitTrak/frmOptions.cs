using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PermitTrak
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            try 
            {
                //Close the option form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //private void cmdBrowseDBLocation_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Displays an OpenFileDialog so the user can select a Database.
        //        OpenFileDialog objopenFileDialog = new OpenFileDialog();
        //        objopenFileDialog.Filter = "Microsoft Access Database|*.accdb";
        //        objopenFileDialog.Title = "Select a Microsoft Access Database File";

        //        // Show the Dialog.
        //        // If the user clicked OK in the dialog and
        //        // a .accdb file was selected, add the path to the text box. 
        //        if (objopenFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            // Assign the database file in the Stream to the Form's Cursor property.
        //            string DBName = objopenFileDialog.FileName;
        //            txtDBLocation.Text = DBName;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "PermitTrak",
        //        MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        //}

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                ////Create the array for the text file
                //string[] writeLines = { txtDBLocation.Text };

                ////Write all items from the array to the text file
                //File.WriteAllLines(clsGlobal.configFileName, writeLines);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            try
            {
                ////Check if file exists. If not do not read
                //if (File.Exists(clsGlobal.configFileName))
                //{
                //    //Open the AppSettings file and read the values in to the options form fields
                //    string[] readLines = File.ReadAllLines(clsGlobal.configFileName);

                //    string readLine = string.Empty;

                //    readLine = readLines[0];
                //    txtDBLocation.Text = readLine;
                //}
                //else
                //{
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
