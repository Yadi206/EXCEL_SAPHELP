using EXCEL_SAPHELP;
using Microsoft.Office.Interop.Excel;
 

public class ExcelApp
{
	private static ExcelApp instance;

	public Application App { get; set; }

	public Workbook ThisWorkbook => App.ActiveWorkbook;

	public Worksheet ActiveSheet => (dynamic)App.ActiveSheet;

	public bool ScreentUpdate
	{
		get
		{
			return App.ScreenUpdating;
		}
		set
		{
			App.ScreenUpdating = value;
		}
	}

	public bool DisplayAlerts
	{
		get
		{
			return App.DisplayAlerts;
		}
		set
		{
			App.DisplayAlerts = value;
		}
	}

	public bool DisplayFormulas
	{
		get
		{
			if (App.ActiveWindow == null)
			{
				return false;
			}
			return App.ActiveWindow.DisplayFormulas;
		}
		set
		{
			try
			{
				if (App.ActiveWindow != null)
				{
					App.ActiveWindow.DisplayFormulas = value;
				}
			}
			catch
			{
			}
		}
	}

	public ExcelApp()
	{
		App = Globals.ThisAddIn.Application;
	}

	public ExcelApp(Application app)
	{
		App = app;
	}

	public static ExcelApp GetInstance()
	{
		if (instance == null)
		{
			instance = new ExcelApp();
		}
		return instance;
	}
}
