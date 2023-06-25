namespace the_zoo
{
    internal class CsvSerializer
    {
        public string Serialize(List<ISerializableObject> serializables)
        {
            IEnumerable<string> serializedObjects = serializables.Select((serializable) => serializable.Serialize());
            return string.Join($"{Environment.NewLine}", serializedObjects);
        }
    }
}
