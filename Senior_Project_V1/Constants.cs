namespace Senior_Project_V1
{
    /// <summary>
    /// General constant variables
    /// </summary>
    public static class GeneralConstants
    {
        //API Key here
        public const string OxfordAPIKey = "<API Key>";
        //API Endpoint here
        public const string FaceAPIEndpoint = "https://westus.api.cognitive.microsoft.com/face/v1.0";
        
        // Name of the folder in which all Whitelist data is stored
        public const string WhiteListFolderName = "Facial Recognition Door Whitelist";

    }


    /// Constant variables that hold messages to be read via the SpeechHelper class
    public static class SpeechContants
    {

        public const string VisitorNotRecognizedMessage = "Sorry! I don't recognize you";
        public const string NoCameraMessage = "Sorry! It seems like your camera has not been fully initialized.";
    }
}
