using Godot;
using Core;
using Data;
using System.Threading.Tasks;

/// <summary>
/// Handles the main scene
/// </summary>
public partial class Dialogs : Node {
    [Export] TextureRect Background;
    [Export] Label DialogCharacter;
    [Export] Label DialogText;

    private string fullText = "";
    private bool isWriting = false;
    private float letterDelay = 0.03f; // delay between letters (seconds)

    /// <summary>
    /// Loads screen
    /// </summary>
    public override void _Ready() {
        FillScreen();
    }

    /// <summary>
    /// Updates the screen components
    /// </summary>
    async void FillScreen() {
        var dialog = Game.GetCurrentDialog;
        string path = "res://Assets/Backgrounds/" + dialog.Background;
        Image image = new Image();
        var error = image.Load(path);

        if (error == Error.Ok) {
            ImageTexture texture = ImageTexture.CreateFromImage(image);
            Background.Texture = texture;
        }
        else {
            GD.PrintErr("Error loading picture: ", error);
        }

        DialogCharacter.Text = dialog.Character;

        fullText = dialog.Text;
        DialogText.Text = "";
        isWriting = true;

        for (int i = 0; i < fullText.Length; i++) {
            if (!isWriting) {
                DialogText.Text = fullText;
                break;
            }

            DialogText.Text += fullText[i];
            await ToSignal(GetTree().CreateTimer(letterDelay), "timeout");
        }

        isWriting = false;
    }

    /// <summary>
    /// Check the inputs events.
    /// If the mouse or a key is presssed, shows next dialog
    /// </summary>
    /// <param name="event">Event</param>
    public override void _Input(InputEvent @event) {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed
            || @event is InputEventMouseButton mouseEvent && mouseEvent.Pressed) {
            
            if (isWriting) {
                // Stills writing, lets show the complete text
                isWriting = false;
            } else {
                // Next dialog
                Game.AdvanceDialog();
                FillScreen();
            }
        }
    }
}
