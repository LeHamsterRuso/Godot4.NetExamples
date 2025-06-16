namespace Data;

/// <summary>
/// Class to handle a dialog
/// </summary>
public class Dialog {
    /// <summary>
    /// Background picture
    /// </summary>
    public string Background { get; set; } = "001.png";
    /// <summary>
    /// Who is speaking
    /// </summary>
    public string Character { get; set; } = string.Empty;
    /// <summary>
    /// What it says
    /// </summary>
    public string Text { get; set; } = string.Empty;   
}
