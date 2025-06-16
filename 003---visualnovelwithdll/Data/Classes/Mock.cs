namespace Data;

/// <summary>
/// Mock to simulate a BD
/// </summary>
static class Mock {
    /// <summary>
    /// List of dialogs
    /// </summary>
    public static List<Dialog> Dialogs = new List<Dialog>() {
        new Dialog() {
            Background = "001.png",
            Character = "Narrator",
            Text = "It was a sweet summer day in this Isekai-style universe."
        },
        new Dialog() {
            Background = "001.png",
            Character = "Narrator",
            Text = "And then she appeared, a sweet green elf..."
        },
        new Dialog() {
            Background = "002.png",
            Character = "Gidna",
            Text = "Excuse me, good sir...\nWould you happen to have a few coins for a little beer?"
        },
        new Dialog() {
            Background = "003.png",
            Character = "Gidna",
            Text = "Believe it or not,\nI'm allergic to water."
        },
    };
}
