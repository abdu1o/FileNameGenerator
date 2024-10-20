using System.Text;

namespace FileNameGenerator
{
    public class FileNameGeneratorService
    {
        private static readonly char[] AllowedChars = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

        public string GenerateFileName(int length)
        {
            if (length <= 0) throw new ArgumentException("Length should be greater than 0");

            var fileName = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                char randomChar = AllowedChars[random.Next(AllowedChars.Length)];
                fileName.Append(randomChar);
            }

            return fileName.ToString();
        }

    }
}
