using System;

namespace UnitTestDemo
{
    public class Letter
    {
        public string FirstLineOfAddress(Address address)
        {
            return address.Number + " " + address.Street;
        }
    }
}
