using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
    class Program
    {
        static void Main() 
        {
            Application.Run(new MainWindow("My Window", 200, 300));
        }
    }
	
    class MainWindow : Form 
    {
        
	  private MenuStrip mnuMainMenu = new MenuStrip();
	  private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
	  private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();

	  public MainWindow(string title, int height, int width)
		{
			Text = title;
			Width = width;
			Height = height;
			CenterToScreen();
			BuildMenuSystem();
		}

	  private void BuildMenuSystem()
	  {
		
		mnuFile.Text = "&File";
		mnuMainMenu.Items.Add(mnuFile);

		
		mnuFileExit.Text = "E&xit";
		mnuFile.DropDownItems.Add(mnuFileExit);
		mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);

		
		Controls.Add(this.mnuMainMenu);
		MainMenuStrip = this.mnuMainMenu;
	  }


	  private void mnuFileExit_Click(object sender, EventArgs e)
	  {
		Application.Exit();
	  }
									
	}
}