﻿using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using MiniShop.UI.Extensions;
using MiniShop.UI.Helpers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public async Task<IActionResult> Index(bool id = false)
        {
            Response<List<ProductViewModel>> result = await _productManager.GetAllNonDeletedAsync(id);
            ViewBag.ShowDeleted = id;
            return View(result.Data);
        }
        
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var result = await _productManager.UpdateIsHomeAsync(id);
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var result = await _productManager.UpdateIsActiveAsync(id);
            return RedirectToAction("Index");
        }
        
        //[NonAction]
        //public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        //{
        //    Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Categories");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Create()
        //{
        //    AddProductViewModel model = new AddProductViewModel
        //    {
        //        Categories = await GetCategoriesAsync()
        //    };
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(AddProductViewModel model, IFormFile image)
        //{
        //    model.Url = Jobs.GetUrl(model.Name);

        //    if (ModelState.IsValid && model.CategoryIds.Count > 0 && image != null)
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            //Resim Yükleme İşlemi
        //            using (var stream = image.OpenReadStream())
        //            {
        //                var imageContent = new MultipartFormDataContent();
        //                byte[] bytes = stream.ToByteArray();
        //                imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
        //                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:7700/Products/ImageUpload", imageContent);
        //                string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
        //                if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
        //                {
        //                    model.ImageUrl = httpResponseMessageImageUrl;
        //                    //Product Kayıt İşlemi
        //                    var serializeModel = JsonSerializer.Serialize(model);
        //                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
        //                    var result = await httpClient.PostAsync("http://localhost:7700/Products/Create", stringContent);
        //                    if (result.IsSuccessStatusCode)
        //                    {
        //                        return RedirectToAction("Index");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
        //    ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Resim hatalı!" : null;
        //    model.Categories = await GetCategoriesAsync();

        //    return View(model);
        //}

        //[NonAction]
        //public async Task<ProductViewModel> GetProductAsync(int id)
        //{
        //    Response<ProductViewModel> response = new Response<ProductViewModel>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/Products/GetWithCategories/{id}");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}

        //[NonAction]
        //public async Task<ProductViewModel> GetByIdAsync(int id)
        //{
        //    Response<ProductViewModel> response = new Response<ProductViewModel>();
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/Products/{id}");
        //        string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
        //        response = JsonSerializer.Deserialize<Response<ProductViewModel>>(contentResponseApi);
        //    }
        //    return response.Data;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    ProductViewModel productViewModel = await GetProductAsync(id);
        //    EditProductViewModel model = new EditProductViewModel
        //    {
        //        Id = productViewModel.Id,
        //        Name = productViewModel.Name,
        //        ImageUrl = productViewModel.ImageUrl,
        //        IsActive = productViewModel.IsActive,
        //        IsHome = productViewModel.IsHome,
        //        Price = productViewModel.Price,
        //        Properties = productViewModel.Properties,
        //        Url = productViewModel.Url,
        //        CategoryIds = productViewModel.CategoryList.Select(c => c.Id).ToList(),
        //        Categories = await GetCategoriesAsync()
        //    };
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(EditProductViewModel model, IFormFile image, string oldImageUrl)
        //{

        //    model.Url = Jobs.GetUrl(model.Name);

        //    if (ModelState.IsValid && model.CategoryIds.Count > 0)
        //    {
        //        using (var httpClient = new HttpClient())
        //        {

        //            //Resim Yükleme İşlemi
        //            using (var stream = image != null ? image.OpenReadStream() : null)
        //            {
        //                if (image != null)
        //                {
        //                    var imageContent = new MultipartFormDataContent();
        //                    byte[] bytes = stream.ToByteArray();
        //                    imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
        //                    HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:7700/Products/ImageUpload", imageContent);
        //                    string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
        //                    if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
        //                    {
        //                        model.ImageUrl = httpResponseMessageImageUrl;

        //                    }
        //                }
        //                //Product Kayıt İşlemi
        //                //model.ImageUrl = model.ImageUrl==null ? oldImageUrl : model.ImageUrl;
        //                var serializeModel = JsonSerializer.Serialize(model);
        //                StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
        //                var result = await httpClient.PutAsync("http://localhost:7700/Products/Update", stringContent);
        //                if (result.IsSuccessStatusCode)
        //                {
        //                    return RedirectToAction("Index");
        //                }


        //            }
        //        }
        //    }
        //    ViewBag.CategoryErrorMessage = model.CategoryIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
        //    model.Categories = await GetCategoriesAsync();
        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    ProductViewModel productViewModel = await GetProductAsync(id);
        //    DeleteProductViewModel model = new DeleteProductViewModel
        //    {
        //        Id = productViewModel.Id,
        //        Name = productViewModel.Name,
        //        Price = productViewModel.Price,
        //        CreatedDate = productViewModel.CreatedDate,
        //        ModifiedDate = productViewModel.ModifiedDate,
        //        IsDeleted = productViewModel.IsDeleted,
        //    };
        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> HardDelete(int id)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:7700/Products/HardDelete/{id}");
        //    }
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public async Task<IActionResult> SoftDelete(int id)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:7700/Products/SoftDelete/{id}");
        //    }
        //    var productViewModel = await GetByIdAsync(id);
        //    //localhost:7000/Product/Index/False
        //    //return RedirectToAction("Index"); //RedirectToAction'ın farklı kullanımlarını araştırın.
        //    //TempData isimli veri taşıma yöntemini araştırın. ViewBag ile temel farkını anlamaya çalışın.
        //    return Redirect($"/Admin/Product/Index/{!productViewModel.IsDeleted}");
        //}
    }
}
