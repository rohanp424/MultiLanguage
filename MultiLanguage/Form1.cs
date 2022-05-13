using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Malayalam")
            {
                ResourceManager rm = new ResourceManager("MultiLanguage.Resource1", Assembly.GetExecutingAssembly());
                label1.Text = "നിങ്ങൾ മലയാളം തിരഞ്ഞെടുതിരികയാണ്";
                label2.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
            }
            else if(comboBox1.Text=="English")
            {
                label1.Text = "You have chosen English";
                label2.Text = "Name";
                label3.Text = "Language";
            }
            else if (comboBox1.Text == "Hindi")
            {
                ResourceManager rm = new ResourceManager("MultiLanguage.Resource2", Assembly.GetExecutingAssembly());
                label1.Text = "आपने हिंदी को चुना है";
                label2.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
            }
            else if (comboBox1.Text == "Telugu")
            {
                ResourceManager rm = new ResourceManager("MultiLanguage.Resource4", Assembly.GetExecutingAssembly());
                label1.Text = "మీరు తెలుగును ఎంచుకున్నారు";
                label2.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
            }
            else if (comboBox1.Text == "Kannada")
            {
                ResourceManager rm = new ResourceManager("MultiLanguage.Resource3", Assembly.GetExecutingAssembly());
                label1.Text = "ನೀವು ಕನ್ನಡವನ್ನು ಆಯ್ಕೆ ಮಾಡಿಕೊಂಡಿದ್ದೀರಿ";
                label2.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
            }
            else if (comboBox1.Text == "Tamil")
            {
                ResourceManager rm = new ResourceManager("MultiLanguage.Resource5", Assembly.GetExecutingAssembly());
                label1.Text = "நீங்கள் தமிழைத் தேர்ந்தெடுத்துள்ளீர்கள்";
                label2.Text = rm.GetString("Name");
                label3.Text = rm.GetString("Language");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ResourceManager rm = new ResourceManager("MultiLanguage.Resource5", Assembly.GetExecutingAssembly());
            label1.Text = "நீங்கள் தமிழைத் தேர்ந்தெடுத்துள்ளீர்கள்";
            label2.Text = rm.GetString("Name");
            label3.Text = rm.GetString("Language");
        }
    }
}
