using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBooks.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        //allows you to add items to the cart
        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        //allows you to remove items from the cart
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();
        public decimal ComputeTotalSum() => Lines.Sum(e => 25 * e.Quantity);

        // getting and setting the id of item in the cart, the book and the quantity 

        public class CartLine
        {
            public int CartLineId { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
