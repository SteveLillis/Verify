public class DisableScrubTempPathTests :
    BaseTest
{
    string tempDir = Path.GetTempPath();

    public DisableScrubTempPathTests() =>
        VerifierSettings.DontScrubTempPath();

    [Fact(Skip = "explicit")]
    public Task Simple() =>
        Verify(tempDir);

    [Fact(Skip = "explicit")]
    public Task Wrapped() =>
        Verify($" {tempDir} ");
}