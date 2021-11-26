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


        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtnClick(object sender, EventArgs e)
        {


            String my_Path = "MyFile.txt";
            String fileName = "App_records.txt";
            String currentSectionNumFile = "currentSectionNumber.txt";
            String cntrFromFile = "";

            inputGender = rdBtnMale_Gender.Checked ? "Male" : rdBtnFemale_Gender.Checked ? "Female" : "";
            isFever_Str = rdBtnYes_Fever.Checked ? "Yes" : rdBtnNo_Fever.Checked ? "No" : "";
            isDryCough_Str = rdBtnYes_DryCough.Checked ? "Yes" : rdBtnNo_DryCough.Checked ? "No" : "";
            isSoreThroat_Str = rdBtnYes_SoreThroat.Checked ? "Yes" : rdBtnNo_SoreThroat.Checked ? "No" : "";
            isTirediness_Str = rdBtnYes_Tirediness.Checked ? "Yes" : rdBtnNo_Tiredines.Checked ? "No" : "";


            if (File.Exists(currentSectionNumFile))
            {
                MessageBox.Show("current Section Exist");
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
                MessageBox.Show("sectionNumber" + sectionNumber.ToString());
            }
            else
            {
                MessageBox.Show("current Section NOT Exist");
                sectionNumber = 1;
                StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                sectionFileconten.Write(sectionNumber.ToString());
                sectionFileconten.Close();
                MessageBox.Show("sectionNumber" + sectionNumber.ToString());
            }


                formContent = "Section " + sectionNumber.ToString() + ":\n"
                        + "Name: " + tabCh +                txtBxFirstName.Text + tabCh + txtBxMiddleName.Text + tabCh + txtBxLastName.Text + newLineCh
                        + "Age: " + tabCh +                 txtBxAge.Text + newLineCh
                        + "Contact Number: " + tabCh +      txtBxContactNum.Text + newLineCh
                        + "E-Mail: " + tabCh +              txtBxEMail.Text + newLineCh
                        + "Gender: " + tabCh +              inputGender + newLineCh
                        + "Date: " + tabCh +                dateDTP.Text + newLineCh
                        + "Barangay: " + tabCh +            txtBxBarangay.Text + newLineCh + newLineCh

                        + "*Health Condition" + tabCh + newLineCh
                        + "If Has Fever: " + tabCh +           isFever_Str +  newLineCh
                        + "If Has Dry Cough " + tabCh +        isDryCough_Str + newLineCh
                        + "If Has Sore Throat: " + tabCh +     isSoreThroat_Str + newLineCh
                        + "If Has Tiredines: " + tabCh +       isTirediness_Str + newLineCh + newLineCh
                        + "END_OF_SECTION_" + sectionNumber.ToString() + newLineCh + newLineCh + newLineCh;

            MessageBox.Show(formContent);



            if (File.Exists(fileName))
            {
                MessageBox.Show("File Exist");
                StreamWriter outputFile = File.AppendText(fileName);
                outputFile.WriteLine(formContent);
                outputFile.Close();

                sectionNumber++;
                StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                sectionFileconten.Write(sectionNumber.ToString());
                sectionFileconten.Close();
            }
            else
            {
                MessageBox.Show("File Not Exist");
                sectionNumber = 1;
                StreamWriter outputFile = File.CreateText(fileName);
                outputFile.WriteLine(formContent);
                outputFile.Close();

                sectionNumber++;
                StreamWriter sectionFileconten = File.CreateText(currentSectionNumFile);
                sectionFileconten.Write(sectionNumber.ToString());
                sectionFileconten.Close();
            }

            






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

            resetForm();

        }


        /*
        private bool isinputsValid()
        {

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
    }
}
