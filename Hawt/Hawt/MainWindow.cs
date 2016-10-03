using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Gtk;

public partial class MainWindow: Gtk.Window
{

	private string myPath = "/home/martin/ownCloud/Photos/";
	private string File1 = "";
	private string File2 = "";
	private Random rnd = new Random();
	FileInfo[] files;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		DirectoryInfo di = new DirectoryInfo(myPath);
		files = di.GetFiles ();

		nextComparison (this.myPath);
	}

	public void nextComparison(string Path) {
		
		File1 = files [rnd.Next(files.GetLength(0)-1)].FullName;
		File2 = files [rnd.Next(files.GetLength(0)-1)].FullName;

		var buffer1 = System.IO.File.ReadAllBytes (File1);
		var pixbuf1 = new Gdk.Pixbuf (buffer1);

		pixbuf1.ScaleSimple (500, pixbuf1.Height * (pixbuf1.Width / pixbuf1.Height), Gdk.InterpType.Nearest);

		image1.Pixbuf = pixbuf1;
		image1.WidthRequest  = 500;
		image1.HeightRequest = pixbuf1.Height * (pixbuf1.Width / pixbuf1.Height);

		var buffer2 = System.IO.File.ReadAllBytes (File2);
		var pixbuf2 = new Gdk.Pixbuf (buffer2);

		pixbuf2.ScaleSimple (500, pixbuf2.Height * (pixbuf2.Width / pixbuf1.Height), Gdk.InterpType.Nearest);

		image2.Pixbuf = pixbuf2;
		image1.WidthRequest  = 500;
		image1.HeightRequest = pixbuf1.Height * (pixbuf1.Width / pixbuf1.Height);

	}
		
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		score (File1, File2);
		nextComparison (this.myPath);
	}

	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		score (File2, File1);
		nextComparison (this.myPath);
	}

	private void score(string fn1, string fn2) {

		string hawtDir = myPath + "/.hawt/";
		string hawtFN = hawtDir + fn1.Substring (fn1.LastIndexOf ('/')+1) + ".hawt";
		if (!Directory.Exists (hawtDir)) {
			Directory.CreateDirectory (hawtDir);
		}

		StreamWriter x = File.AppendText(hawtFN);
		x.WriteLine ("X");
		x.Close ();
	}

}
