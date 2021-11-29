using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Linq;



namespace MyContactTracing
{
    public partial class Form1 : Form
    {

        String formContent = "";
        String tabCh = "\t";
        String newLineCh = "\n";
        int sectionNumber = 0;

        String inputGender =  "";
        String isFever_Str = "";
        String isDryCough_Str =  "";
        String isSoreThroat_Str = "";
        String isTirediness_Str = "";


        String fileName = "App_records.txt";
        String currentSectionNumFile = "currentSectionNumber.txt";
        String cntrFromFile = "";


        public Form1()
        {
            InitializeComponent();

            dateDTP.MinDate = DateTime.Now;
            dateDTP.MaxDate = DateTime.Now;

        }

        private void saveBtnClick(object sender, EventArgs e)
        {
            
          
            if(isFormCompled())
            {

                if (File.Exists(currentSectionNumFile))
                {
                    //MessageBox.Show("current Section Exist");
                    StreamReader sectionFilecontent = File.OpenText(currentSectionNumFile);
                    cntrFromFile = sectionFilecontent.ReadLine();
                    /*
                    while (!sectionFilecontent.EndOfStream)
                    {
                        cntrFromFile = sectionFilecontent.ReadLine();
                    }
                    */
                    sectionFilecontent.Close();
                    sectionNumber = int.Parse(cntrFromFile);
                    sectionNumber++;
                    //MessageBox.Show("sectionNumber" + sectionNumber.ToString());
                }
                else
                {
                    //MessageBox.Show("current Section NOT Exist");
                    sectionNumber = 1;
                    StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                    sectionFileconten.Write(sectionNumber.ToString());
                    sectionFileconten.Close();
                    //MessageBox.Show("sectionNumber" + sectionNumber.ToString());
                }

                inputGender = rdBtnMale_Gender.Checked ? "Male" : rdBtnFemale_Gender.Checked ? "Female" : "";
                isFever_Str = rdBtnYes_Fever.Checked ? "Yes" : rdBtnNo_Fever.Checked ? "No" : "";
                isDryCough_Str = rdBtnYes_DryCough.Checked ? "Yes" : rdBtnNo_DryCough.Checked ? "No" : "";
                isSoreThroat_Str = rdBtnYes_SoreThroat.Checked ? "Yes" : rdBtnNo_SoreThroat.Checked ? "No" : "";
                isTirediness_Str = rdBtnYes_Tirediness.Checked ? "Yes" : rdBtnNo_Tiredines.Checked ? "No" : "";

                formContent = "Section " + sectionNumber.ToString() + ":\n"
                            + "Name: " + tabCh + txtBxFirstName.Text + tabCh + txtBxMiddleName.Text + tabCh + txtBxLastName.Text + newLineCh
                            + "Age: " + tabCh + txtBxAge.Text + newLineCh
                            + "Contact Number: " + tabCh + txtBxContactNum.Text + newLineCh
                            + "E-Mail: " + tabCh + txtBxEMail.Text + newLineCh
                            + "Gender: " + tabCh + inputGender + newLineCh
                            + "Date: " + tabCh + dateDTP.Text + newLineCh
                            + "Barangay: " + tabCh + txtBxBarangay.Text + newLineCh + newLineCh

                            + "*Health Condition" + tabCh + newLineCh
                            + "If Has Fever: " + tabCh + isFever_Str + newLineCh
                            + "If Has Dry Cough " + tabCh + isDryCough_Str + newLineCh
                            + "If Has Sore Throat: " + tabCh + isSoreThroat_Str + newLineCh
                            + "If Has Tiredines: " + tabCh + isTirediness_Str + newLineCh + newLineCh
                            + "END_OF_SECTION_" + sectionNumber.ToString() + newLineCh + newLineCh + newLineCh;

                MessageBox.Show(formContent);

                if (File.Exists(fileName))
                {
                    //MessageBox.Show("File Exist");
                    StreamWriter outputFile = File.AppendText(fileName);
                    outputFile.WriteLine(formContent);
                    outputFile.Close();

                    //sectionNumber++;
                    StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                    sectionFileconten.Write(sectionNumber.ToString());
                    sectionFileconten.Close();
                }
                else
                {
                    //MessageBox.Show("File Not Exist");
                    //sectionNumber = 1;
                    StreamWriter outputFile = File.CreateText(fileName);
                    outputFile.WriteLine(formContent);
                    outputFile.Close();

                    //sectionNumber++;
                    StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                    sectionFileconten.Write(sectionNumber.ToString());
                    sectionFileconten.Close();
                }

                resetForm();
            }
            else
            {
                ifEmptyFieldWarning();
                MessageBox.Show("Please Complete the Form");
                resestBackColor();
            }

           

            //resetForm();

        }


        private void ifEmptyFieldWarning()
        {
            if (txtBxFirstName.Text == "")
            {
                txtBxFirstName.BackColor = Color.Red;
            }
            if (txtBxMiddleName.Text == "")
            {
                txtBxMiddleName.BackColor = Color.Red;
            }
            if (txtBxLastName.Text == "")
            {
                txtBxLastName.BackColor = Color.Red;
            }
            if (txtBxAge.Text == "")
            {
                txtBxAge.BackColor = Color.Red;
            }
            if (txtBxContactNum.Text == "")
            {
                txtBxContactNum.BackColor = Color.Red;
            }
            if (txtBxEMail.Text == "")
            {
                txtBxEMail.BackColor = Color.Red;
            }
            if (txtBxBarangay.Text == "")
            {
                txtBxBarangay.BackColor = Color.Red;
            }



            if(rdBtnMale_Gender.Checked == rdBtnFemale_Gender.Checked)
            {
                grpBxGender.BackColor = Color.Red;
            }

            if (rdBtnYes_Fever.Checked == rdBtnNo_Fever.Checked)
            {
                grpBxFever.BackColor = Color.Red;
            }
            if (rdBtnYes_DryCough.Checked == rdBtnNo_DryCough.Checked)
            {
                grpBxDryCough.BackColor = Color.Red;
            }
            if (rdBtnYes_SoreThroat.Checked == rdBtnNo_SoreThroat.Checked)
            {
                grpBxSoreThroat.BackColor = Color.Red;
            }
            if (rdBtnYes_Tirediness.Checked == rdBtnNo_Tiredines.Checked)
            {
                grpBxTirediness.BackColor = Color.Red;
            }

        }


        private void resestBackColor()
        {
            txtBxFirstName.BackColor = Color.White;
            txtBxMiddleName.BackColor = Color.White;
            txtBxLastName.BackColor = Color.White;
            txtBxAge.BackColor = Color.White;
            txtBxContactNum.BackColor = Color.White;
            txtBxEMail.BackColor = Color.White;
            txtBxBarangay.BackColor = Color.White;


            grpBxGender.BackColor = Color.White;
            grpBxFever.BackColor = Color.White;
            grpBxDryCough.BackColor = Color.White;
            grpBxSoreThroat.BackColor = Color.White;
            grpBxTirediness.BackColor = Color.White;

        }



        private bool isNotEmptyTextBoxes()
        {
            if ((txtBxFirstName.Text != "") && (txtBxFirstName.Text != "") && (txtBxMiddleName.Text != "") && (txtBxLastName.Text != "") && (txtBxAge.Text != "") && (txtBxContactNum.Text != "") && (txtBxBarangay.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //*
        private bool isFormCompled()
        {
            
           if (((txtBxFirstName.Text != "") && (txtBxMiddleName.Text != "") && (txtBxLastName.Text != "") && (txtBxAge.Text != "") && (txtBxContactNum.Text != "") && (txtBxBarangay.Text != ""))
                && ((rdBtnMale_Gender.Checked != rdBtnFemale_Gender.Checked) &&
                (rdBtnYes_Fever.Checked != rdBtnNo_Fever.Checked) && (rdBtnYes_DryCough.Checked != rdBtnNo_DryCough.Checked) 
                && (rdBtnYes_SoreThroat.Checked != rdBtnNo_SoreThroat.Checked) && (rdBtnYes_Tirediness.Checked != rdBtnNo_Tiredines.Checked))) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //*/

        private void resetForm()
        {
            txtBxFirstName.Text = "";
            txtBxMiddleName.Text = "";
            txtBxLastName.Text = "";
            txtBxAge.Text = "";
            txtBxContactNum.Text = "";
            txtBxEMail.Text = "";
            rdBtnMale_Gender.Checked = false;
            rdBtnFemale_Gender.Checked = false;
            txtBxBarangay.Text = "";
            
            rdBtnYes_Fever.Checked = false;
            rdBtnNo_Fever.Checked = false;
            
            rdBtnYes_DryCough.Checked = false;
            rdBtnNo_DryCough.Checked = false;
            
            rdBtnYes_SoreThroat.Checked = false;
            rdBtnNo_SoreThroat.Checked = false;
            
            rdBtnYes_Tirediness.Checked = false;
            rdBtnNo_Tiredines.Checked = false;
        }

        private void newRecordFrom(object sender, EventArgs e)
        {
            resetForm();
        }

        private void keyPress_Letters_Spaces(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void keyPress_Letters_Spaces_Numbers_Period(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsNumber(e.KeyChar) && (e.KeyChar.ToString() != ".")))
            {
                e.Handled = true;
            }
        }

        private void keyPres_EMail(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsNumber(e.KeyChar))
                && (e.KeyChar.ToString() != ".") && (e.KeyChar.ToString() != "@") && (e.KeyChar.ToString() != "_"))
            {
                e.Handled = true;
            }
        }

        private void keyPress_Numbers(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

       

        private void btnViewRecords_Click(object sender, EventArgs e)
        {

            if (File.Exists(fileName))
            {
                String line = "";

                StreamReader inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine() + "\n";
                    rchTxtBxDisplayRecords.AppendText(line);
                }
                //MessageBox.Show("End of File");
                inputFile.Close();


                btnViewRecords.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Records has been save yet");
            }
                
           
        }

        private void keyPressrchTxtBxDisplayRecords(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            rchTxtBxDisplayRecords.Clear();
            //rchTxtBxDisplayRecords.ScrollBars = RichTextBoxScrollBars.None;
            btnViewRecords.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abooutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Tan, Frederick B. ", "Contact Tracing App");
        }









        /*
         

            if((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        */







        /*
        int a;
        StreamReader inputFile = File.OpenText("App_records.txt");
        while(!inputFile.EndOfStream)
        {
            inputFile.ReadLine();
            //MessageBox.Show("Next line...");
        }
        MessageBox.Show("End of File");
        inputFile.Close();

        //* /


        StreamWriter myFileWritter = File.CreateText("App_records.txt");
        myFileWritter.WriteLine(formContent);
        myFileWritter.Close();
        //* /

        StreamWriter myFileAppend = File.AppendText("App_records.txt");
        myFileAppend.WriteLine(formContent);
        myFileAppend.Close();

        //*/


    }
}
