using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace employee
{
    public partial class Form1 : Form
    {
		int j;
		XmlNodeList street_list ;
		XmlNodeList no_list ;
		XmlNodeList region_list ;
		XmlNodeList city_list ;
		XmlNodeList country_list;
		XmlNodeList mobile_list;
		XmlNodeList home_list;
		XmlNodeList name_list;
		XmlNodeList mail_list;
		XmlNodeList all;
		XmlDocument doc;
		string path = @"G:\ITI\xml\labs\employee\employee\contacts.xml";
		public Form1()
        {
            InitializeComponent();
			j = 0;

        }

		private void button_prev_Click(object sender, EventArgs e)
		{
			if (j > 0)
			{
				empty_form();
				j--;
				if (j == 0)
				{
					button_prev.Enabled = false;
				}
				fill_function();
			}
			
        }

        private void Form1_Load(object sender, EventArgs e)
        {
		     doc = new XmlDocument();
			doc.Load(path);
			fill_function();
			if (j == 0)
			{
				button_prev.Enabled = false;
			}
			else
			{
				button_prev.Enabled = true;
			}

		}
		public void empty_form()
		{
			//
			listBox_city.Items.Clear();
			listBox_region.Items.Clear();
			listBox_no.Items.Clear();
			listBox_counry.Items.Clear();
			listBox_city.Items.Clear();
			listBox_home.Items.Clear();
			listBox_mobile.Items.Clear();
		}
		private void button_next_Click(object sender, EventArgs e)
		{
			button_prev.Enabled = true;
			empty_form();
			j++;
			fill_function();
			Refresh();
			
		}

		public void fill_function()
		{
		    name_list = doc.GetElementsByTagName("name");
			textBox_name.Text = name_list[j].InnerText;
		    home_list = doc.SelectNodes("/contacts/employee/phones/phone[@Type='home']");
			listBox_home.Items.Add(home_list[j].InnerText);

			 mobile_list = doc.SelectNodes("/contacts/employee/phones/phone[@Type='mobile']");
			listBox_mobile.Items.Add(mobile_list[j].InnerText);

		     street_list = doc.GetElementsByTagName("street");
             no_list = doc.GetElementsByTagName("buldingNumber");
			 region_list = doc.GetElementsByTagName("region");
			 city_list = doc.GetElementsByTagName("city");
			 country_list = doc.GetElementsByTagName("country");
			listBox_street.Items.Add(street_list[j].InnerText);
			listBox_no.Items.Add(no_list[j].InnerText);
			listBox_region.Items.Add(region_list[j].InnerText);
			listBox_city.Items.Add(city_list[j].InnerText);
			listBox_counry.Items.Add(country_list[j].InnerText);


			 mail_list = doc.GetElementsByTagName("mail");
			textBox_mail.Text = mail_list[j].InnerText;
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			//delete_button
			all = doc.GetElementsByTagName("employee");
			XmlElement root = doc.DocumentElement;
			root.RemoveChild(all[j]);
			j--;
			empty_form();
			fill_function();
			doc.Save(path);
		}
	}
}
