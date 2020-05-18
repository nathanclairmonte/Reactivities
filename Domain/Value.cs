using System;

namespace Domain
{
    public class Value
    {
        // Id name will auto be used as PK
        // int type will use auto gen Id's
        // Will be using Code First in this course
        public int Id { get; set; }
        public string Name  { get; set; }
    }
}
