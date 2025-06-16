using Data;

namespace Core;

/// <summary>
/// Handles the game workflow
/// </summary>
public static class Game
{
    /// <summary>
    /// List of dialogs
    /// </summary>
    static List<Dialog> dialogs = Data.Dialogs;

    /// <summary>
    /// Dialog index
    /// </summary>
    static int currentDialog = 0;

    /// <summary>
    /// Current dialog
    /// </summary>
    public static Dialog GetCurrentDialog { get => dialogs.ElementAt(currentDialog); }

    /// <summary>
    /// Increments the dialog index
    /// </summary>
    public static void AdvanceDialog()
    {
        currentDialog++;
        if (currentDialog == dialogs.Count)
        {
            currentDialog = 0;
        }
    }
}
