using System;

namespace ApplyingAttributes
{
    // This class can be saved to disk.
    [Serializable]
    class Motorcycle
    {
        // However, this field will not be persisted.
        [NonSerialized]
        public float weightOfCurrentPassengers;
        // These fields are still serializable.
        public bool hasRadioSystem = false;
        public bool hasHeadSet = false;
        public bool hasSissyBar = false;
    }
}
