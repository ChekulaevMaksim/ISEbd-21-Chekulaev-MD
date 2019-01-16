using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExterminator
{
	public partial class FormPlaneConfig : Form
	{
		IPlane exterminator = null;

		private event planeDelegate eventAddPlane;

		public FormPlaneConfig()
		{
			InitializeComponent();
			panelBlack.MouseDown += panelColor_MouseDown;
			panelGold.MouseDown += panelColor_MouseDown;
			panelGray.MouseDown += panelColor_MouseDown;
			panelGreen.MouseDown += panelColor_MouseDown;
			panelRed.MouseDown += panelColor_MouseDown;
			panelWhite.MouseDown += panelColor_MouseDown;
			panelOrange.MouseDown += panelColor_MouseDown;
			panelBlue.MouseDown += panelColor_MouseDown;
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawExterminator()
		{
			if (exterminator != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
				Graphics gr = Graphics.FromImage(bmp);
				exterminator.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
				exterminator.DrawExterminator(gr);
				pictureBoxPlane.Image = bmp;
			}
		}

		public void AddEvent(planeDelegate ev)
		{
			if (eventAddPlane == null)
			{
				eventAddPlane = new planeDelegate(ev);
			}
			else
			{
				eventAddPlane += ev;
			}
		}
		private void labelSimpleplane_MouseDown(object sender, MouseEventArgs e)
		{
			labelSimpleplane.DoDragDrop(labelSimpleplane.Text, DragDropEffects.Move |DragDropEffects.Copy);

		}

		private void labelExterminator_MouseDown(object sender, MouseEventArgs e)
		{
			labelExterminator.DoDragDrop(labelExterminator.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelDrop_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}

		}

		private void panelDrop_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Обычный":
					exterminator = new Simpleplane(100, 500, Color.White);
					break;
				case "Истребитель":
					exterminator = new Exterminator(100, 500, Color.White, Color.Black, true, true, true);
					break;
			}
			DrawExterminator();
		}
		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor,
		   DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}

		}

		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (exterminator != null)
			{
				exterminator.SetMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawExterminator();
			}

		}


		private void labelDopColor_DragEnter(object sender, DragEventArgs e)
		{
			if (exterminator != null)
			{
				if (exterminator is Exterminator)
				{
					if (e.Data.GetDataPresent(typeof(Color)))
					{
						e.Effect = DragDropEffects.Copy;
					}
					else
					{
						e.Effect = DragDropEffects.None;
					}
				}
			}
		}
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (exterminator != null)
			{
				if (exterminator is Exterminator)
				{
					(exterminator as Exterminator).SetDopColor((Color)e.Data.GetData(typeof(Color)));
					DrawExterminator();
				}
			}

		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			eventAddPlane?.Invoke(exterminator);
			Close();
		}
	}
}
