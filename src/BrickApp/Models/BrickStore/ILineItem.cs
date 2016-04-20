using System;

namespace BrickApp.Models.BrickStore
{
    public interface ILineItem
    {
        Product Product { get; }
        int Quantity { get; }
        decimal PricePerUnit { get; }
    }
}