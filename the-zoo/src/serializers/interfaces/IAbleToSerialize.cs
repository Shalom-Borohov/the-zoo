namespace the_zoo.src.serializers.interfaces
{
    interface IAbleToSerialize
    {
        string Serialize(List<ISerializableObject> serializables);
    }
}
