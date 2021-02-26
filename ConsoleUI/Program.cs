using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
	//SOLID
	//Open Closed Principle
	class Program
	{
		static void Main(string[] args)
		{
			//Data Transformation Object
			ProductTest();
			//IoC
			//CategoryTest();
			
			
		}
		
		private static void CategoryTest()
		{
			CategoryManager categoryManager = new CategoryManager(EfCategoryDal());
			foreach(var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach(var product in productManager.GetProductDetails())
			{
				Console.WriteLine(product.ProductName + " / " + product.CategoryName);
			}
		}
	}
}