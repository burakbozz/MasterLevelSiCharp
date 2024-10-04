using MasterLevelSiCharp.Models;
using MasterLevelSiCharp.Models.Transformers.Mappers;
using MasterLevelSiCharp.Models.Transformers;

//Console.WriteLine(2 + 5);


//Book book = new Book()
//{
//    Id = 1,
//    Title = "Test",
//    Description = "Test",
//};

//Category category = new Category()
//{
//    Id = 1,
//    Name = "Dram",
//    Books = new List<Book>()
//};


//category = category + book;

//category = category + book;

//category = category + book;

//category = category + book;

//category = category + book;

//category = category - book;

//category = category - book;

//category.Books.ForEach(x => Console.WriteLine(x));



//void AddBookToCategory(Book book)
//{
//    category.Books.Add(book);
//}

CreateElmaDto dto = new CreateElmaDto()
{
    Color = Color.Red,
    KgPrice = 45,
    SellerName = "Muhammed Talha Özer",
    Type = "Yeşil Elma"
};

Elma elma = ElmaMapper.ConvertToEntity(dto);
ElmaResponseDto response = ElmaMapper.ConvertToResponseDto(elma);
Console.WriteLine(response);

Console.WriteLine("**********************************************");

CreateProductDto createProductDto = new CreateProductDto()
{
    Name = "Test",
    Price = 5555.50,
    Stock = 4444

};

Product product = ProductMapper.ConvertToEntity(createProductDto);
ProductResponseDto productResponseDto = ProductMapper.ConvertToResponseDto(product);
Console.WriteLine(productResponseDto);