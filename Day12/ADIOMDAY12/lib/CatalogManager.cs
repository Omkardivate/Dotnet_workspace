namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
    public  List<Products> GetAllProducts(){
        List<Products> ls= DBManager.GetProducts();
        return ls;
    }
}
