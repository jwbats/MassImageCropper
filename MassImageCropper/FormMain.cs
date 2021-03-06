﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace MassImageCropper
{
	public partial class frmMassImageCropper : Form
	{

		public frmMassImageCropper()
		{
			InitializeComponent();

			cbInterpolation.Items.Add(InterpolationMode.High);
			cbInterpolation.Items.Add(InterpolationMode.HighQualityBilinear);
			cbInterpolation.Items.Add(InterpolationMode.HighQualityBicubic);
			cbInterpolation.SelectedIndex = cbInterpolation.Items.Count - 1;

			cbSmoothing.Items.Add(SmoothingMode.None);
			cbSmoothing.Items.Add(SmoothingMode.HighSpeed);
			cbSmoothing.Items.Add(SmoothingMode.HighQuality);
			cbSmoothing.Items.Add(SmoothingMode.AntiAlias);
			cbSmoothing.SelectedIndex = cbSmoothing.Items.Count - 1;
		}


		Image Crop(Image imgPicture, int Width, int Height)
		{
			int sourceWidth = imgPicture.Width;
			int sourceHeight = imgPicture.Height;
			int sourceX = 0;
			int sourceY = 0;
			int destX = 0;
			int destY = 0;

			double nPercent = 0;
			double nPercentW = 0;
			double nPercentH = 0;

			nPercentW = ((double)Width / (double)sourceWidth);
			nPercentH = ((double)Height / (double)sourceHeight);

			if (nPercentH < nPercentW)
			{
				nPercent = nPercentW;
				destY = (int)((Height - (sourceHeight * nPercent)) / 2);
			}
			else
			{
				nPercent = nPercentH;
				destX = (int)((Width - (sourceWidth * nPercent)) / 2);
			}

			int destWidth = (int)(sourceWidth * nPercent);
			int destHeight = (int)(sourceHeight * nPercent);

			Bitmap bmPicture = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
			bmPicture.SetResolution(imgPicture.HorizontalResolution, imgPicture.VerticalResolution);

			bmPicture.MakeTransparent();

			Graphics grPicture = Graphics.FromImage(bmPicture);

			grPicture.InterpolationMode = (InterpolationMode)cbInterpolation.SelectedItem;
			grPicture.SmoothingMode     = (SmoothingMode)cbSmoothing.SelectedItem;
			grPicture.CompositingMode   = CompositingMode.SourceCopy;

			grPicture.DrawImage(imgPicture,
								new Rectangle(destX, destY, destWidth, destHeight),
								new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
								GraphicsUnit.Pixel);

			grPicture.Dispose();
			return bmPicture;
		}


		Image Crop(Image imgPicture)
		{
			int sourceXRes = imgPicture.Width;
			int sourceYRes = imgPicture.Height;

			int destXRes = Convert.ToInt32(tbXRes.Text);
			int destYRes = Convert.ToInt32(tbYRes.Text);

			double aspect = (double)sourceYRes / (double)sourceXRes;

			int destYResAspectRatioCorrect = Convert.ToInt32(aspect * (double)destXRes);

			return (cbKeepAspectRatio.Checked)
				? Crop(imgPicture, destXRes, destYResAspectRatioCorrect)
				: Crop(imgPicture, destXRes, destYRes);
		}


		private void btnPickFolder_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Drag & Drop a folder into the textbox to the left.", "Drag & Drop");
		}


		private void btnPickDestination_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Drag & Drop a folder into the textbox to the left.", "Drag & Drop");
		}


		private bool IsInRange(double d, double min, double max)
		{
			return ((d >= min) && (d <= max));
		}


		private bool IsNumeric(String str)
		{
			try
			{
				int i = int.Parse(str);
			}
			catch
			{
				return false;
			}

			return true;
		}


		private bool IsNumericInRange(String str, double min, double max)
		{
			return IsNumeric(str) && IsInRange(Convert.ToDouble(str), min, max);
		}


		private String[] ExtractFilenames(String[] filePaths)
		{
			for (int i = 0; i < filePaths.Length; i++)
			{
				filePaths[i] = filePaths[i].Remove(0, filePaths[i].LastIndexOf("\\") + 1);
			}

			return filePaths;
		}


		private ImageCodecInfo FindEncoder(ImageFormat fmt)
		{
			ImageCodecInfo[] infoArray1 = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo[] infoArray2 = infoArray1;

			for (int i = 0; i < infoArray2.Length; i++)
			{
				ImageCodecInfo info1 = infoArray2[i];
				if (info1.FormatID.Equals(fmt.Guid))
				{
					return info1;
				}
			}
			return null;
		}


		private List<String> GetFiles(String path, String searchPattern)
		{
			List<String> filePaths = new List<String>();
			String[] patterns = searchPattern.Split(';');

			foreach (String pattern in patterns)
			{
				filePaths.AddRange(Directory.GetFiles(path, pattern));
			}

			return filePaths;
		}


		private List<String> GetFilesRecursively(String path, String searchPattern)
		{
			List<String> folders = new List<String>(Directory.GetDirectories(path));
			List<String> filePaths = new List<String>(GetFiles(path, searchPattern));

			foreach (String folder in folders)
			{
				filePaths.AddRange(GetFilesRecursively(folder, searchPattern));
			}

			return filePaths;
		}


		private ImageFormat GetImageFormat(string filePath)
		{
			string extension = Path.GetExtension(filePath).ToLower();

			switch (extension)
			{
				case ".jpg"  : return ImageFormat.Jpeg;
				case ".jpeg" : return ImageFormat.Jpeg;
				case ".png"  : return ImageFormat.Png;
				case ".gif"  : return ImageFormat.Gif;
				case ".bmp"  : return ImageFormat.Bmp;
				default      : return ImageFormat.Jpeg;
			}
		}


		private void CreateCodecStuff(out EncoderParameters codecParameters, out ImageCodecInfo codecInfo, ImageFormat imageFormat)
		{
			codecParameters          = new EncoderParameters(1);
			codecParameters.Param[0] = new EncoderParameter(Encoder.Quality, (long)hsbQuality.Value);
			codecInfo                = FindEncoder(imageFormat);
		}


		private void btnMassCrop_Click(object sender, EventArgs e)
		{
			bool bFolders = Directory.Exists(tbSourceFolder.Text)
							   && Directory.Exists(tbDestFolder.Text)
							   && !String.Equals(tbSourceFolder.Text, tbDestFolder.Text);

			bool bResolution = IsNumericInRange(tbXRes.Text, 1, 2048)
							   && (cbKeepAspectRatio.Checked || IsNumericInRange(tbYRes.Text, 1, 2048));

			if (!bFolders)
			{
				MessageBox.Show("Please pick existing and unique source- and destination-folders.", "Input Error");
			}

			if (!bResolution)
			{
				MessageBox.Show("Please pick a valid x,y resolution.", "Input Error");
			}

			if (bFolders && bResolution)
			{
				List<String> fileSourcePaths = GetFilesRecursively(tbSourceFolder.Text, "*.jpg;*.jpeg;*.png;*.gif;*.bmp");

				progressBar.Value   = 0;
				progressBar.Maximum = fileSourcePaths.Count;

				if (fileSourcePaths.Count > 0)
				{
					foreach (string fileSourcePath in fileSourcePaths)
					{
						Bitmap bitmap       = new Bitmap(fileSourcePath);
						Image image         = Crop(bitmap);
						String fileDestPath = fileSourcePath.Replace(tbSourceFolder.Text, tbDestFolder.Text);
						String fileDestDir  = Path.GetDirectoryName(fileDestPath);

						if (!Directory.Exists(fileDestDir))
						{
							Directory.CreateDirectory(fileDestDir);
						}

						ImageFormat imageFormat = GetImageFormat(fileSourcePath);

						EncoderParameters codecParameters;
						ImageCodecInfo codecInfo;
						CreateCodecStuff(out codecParameters, out codecInfo, imageFormat);

						image.Save(fileDestPath, codecInfo, codecParameters);
						progressBar.Increment(1);
					}
				} else {
					MessageBox.Show("No input files found.", "No Input");
				}
			}
		}


		private void hsbQuality_Scroll(object sender, ScrollEventArgs e)
		{
			tbQuality.Text = Convert.ToString(e.NewValue);
		}


		private void tbQuality_Leave(object sender, EventArgs e)
		{
			if (IsNumeric(tbQuality.Text))
			{
				int quality = Convert.ToInt32(tbQuality.Text);

				if (quality < 1)
				{
					quality = 1;
				}

				if (quality > 100)
				{
					quality = 100;
				}

				hsbQuality.Value = quality;
				tbQuality.Text = Convert.ToString(quality);
			}
		}

		private void tbXRes_MouseUp(object sender, MouseEventArgs e)
		{
			tbXRes.SelectAll();
		}

		private void tbYRes_MouseUp(object sender, MouseEventArgs e)
		{
			tbYRes.SelectAll();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frmAbout = new FormAbout();
			frmAbout.Show();
		}

		private void cbKeepAspectRatio_CheckedChanged(object sender, EventArgs e)
		{
			tbYRes.ReadOnly = cbKeepAspectRatio.Checked;
		}


		private void tbFolder_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
		}


		private void tbFolder_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				if (e.Effect == DragDropEffects.Copy ||	e.Effect == DragDropEffects.Move ||	e.Effect == DragDropEffects.Link ||	e.Effect == DragDropEffects.All)
				{
					string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
					string directory = files.FirstOrDefault();

					if (Directory.Exists(directory))
					{
						TextBox tbFolder = sender as TextBox;
						tbFolder.Text = directory;
					}
				}
			}
		}

	}
}
