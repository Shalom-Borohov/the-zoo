namespace the_zoo.src.misc.classes
{
    public static class DotEnv
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            File.ReadAllLines(filePath).ToList().ForEach(SetEnvVar);
        }

        private static void SetEnvVar(string line)
        {
            string[] parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 2)
            {
                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
