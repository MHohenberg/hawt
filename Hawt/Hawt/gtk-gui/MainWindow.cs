
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Button button4;
	
	private global::Gtk.Image image1;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Button button5;
	
	private global::Gtk.Image image2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AllowGrow = false;
		this.DestroyWithParent = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.WidthRequest = 1200;
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("hot");
		this.vbox2.Add (this.button4);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button4]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.image1 = new global::Gtk.Image ();
		this.image1.WidthRequest = 500;
		this.image1.Name = "image1";
		this.vbox2.Add (this.image1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image1]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.hbox2.Add (this.vbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
		w3.Position = 0;
		w3.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.WidthRequest = 500;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("hot");
		this.vbox1.Add (this.button5);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button5]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.image2 = new global::Gtk.Image ();
		this.image2.WidthRequest = 0;
		this.image2.Name = "image2";
		this.vbox1.Add (this.image2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.image2]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.hbox2.Add (this.vbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox1]));
		w6.Position = 1;
		w6.Fill = false;
		this.Add (this.hbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1200;
		this.DefaultHeight = 529;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		this.button5.Clicked += new global::System.EventHandler (this.OnButton5Clicked);
	}
}
