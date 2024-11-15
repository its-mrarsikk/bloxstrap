namespace Bloxstrap.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class BuildMetadataAttribute : Attribute
    {
        public DateTime Timestamp { get; set; }
        public string Machine { get; set; }
        public string CommitHash { get; set; }
        public string CommitRef { get; set; }
        public string BaseVersion { get; set; }
        public bool IsReleaseBuild { get; set; }

        public BuildMetadataAttribute(string timestamp, string machine, string commitHash, string commitRef, string baseVersion, string isReleaseBuild)
        {
            Timestamp = DateTime.Parse(timestamp).ToLocalTime();
            Machine = machine;
            CommitHash = commitHash;
            CommitRef = commitRef;
            BaseVersion = baseVersion;
            IsReleaseBuild = bool.Parse(isReleaseBuild);
        }
    }
}
