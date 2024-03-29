﻿namespace RadencyLibrary.CQRS.BookCq.Dto
{
    public class BookDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; } = null!;
    }
}