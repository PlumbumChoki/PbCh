using HW1;
using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);
MessageBox(IntPtr.Zero, "Next message box will be with information", "My Message", 0);
MessageBox(IntPtr.Zero, new Student("Алексей", "Орлов", new DateTime (1990,10,10)).ToString(), "My Message", 0);
