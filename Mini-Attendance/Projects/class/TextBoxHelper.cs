using System.Windows.Forms;

public static class TextBoxHelper
{
    public static void ClearTextBoxes(params TextBox[] textBoxes)
    {
        foreach (var textBox in textBoxes)
        {
            textBox.Clear();
        }
    }

    public static void EnableTextBoxes(bool enable, params TextBox[] textBoxes)
    {
        foreach (var textBox in textBoxes)
        {
            textBox.Enabled = enable;
        }
    }

    public static void FillTextBoxes(DataGridViewRow row, params TextBox[] textBoxes)
    {
        for (int i = 0; i < textBoxes.Length; i++)
        {
            if (i < row.Cells.Count)
            {
                textBoxes[i].Text = row.Cells[i].Value.ToString();
            }
        }
    }
}