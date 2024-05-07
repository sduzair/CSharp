using System.Runtime.InteropServices;

internal class Program
{
  [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
  private static extern int MessageBox(int hWnd, string text, string caption, uint type);

  private static void Main(string[] args)
  {
    MessageBox(0, "Hello World!", "Hello Dialog", 0);
  }
}