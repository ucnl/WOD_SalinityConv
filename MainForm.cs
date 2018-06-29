using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOD_SalinityConv
{
    public partial class MainForm : Form
    {

        #region Properties

        UCNLSalinity.SettingsProviderXML<List<UCNLSalinity.MSDE>> data = new UCNLSalinity.SettingsProviderXML<List<UCNLSalinity.MSDE>>();

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog oDialog = new OpenFileDialog())
            {
                oDialog.CheckFileExists = true;
                oDialog.Filter = "Comma separated values (*.csv)|*.csv";
                oDialog.Title = "Select a WOD salinity data file...";
                oDialog.DefaultExt = "csv";

                if (oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        data.Data = UCNLSalinity.NODCDataReader.WOD09_SalinityData_Read(oDialog.FileName);

                        int latIdx = 0;
                        int lonIdx = 0;

                        Bitmap bm = new Bitmap(360, 180);

                        double maxSal = double.MinValue;
                        double minSal = double.MaxValue;

                        foreach (var item in data.Data)
                        {
                            if (item.Sal > maxSal) maxSal = item.Sal;
                            if (item.Sal < minSal) minSal = item.Sal;
                        }

                        foreach (var item in data.Data)
                        {
                            byte b = Convert.ToByte(Math.Round(127 - 127 * (item.Sal - minSal) / (maxSal - minSal)));
 
                            latIdx = (int)Math.Round(-item.Lat + 89.5);
                            lonIdx = (int)Math.Round(item.Lon + 179.5);

                            bm.SetPixel(lonIdx, latIdx, Color.FromArgb(0, 0, b));                            
                        }

                        pBox.Image = bm;
                        pBox.Invalidate();

                        using (SaveFileDialog sDialog = new SaveFileDialog())
                        {
                            sDialog.DefaultExt = "xml";
                            sDialog.Filter = "XML files (*.xml)|*.xml";
                            sDialog.Title = "Select where to save salinity data...";

                            if (sDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                data.Save(sDialog.FileName);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
