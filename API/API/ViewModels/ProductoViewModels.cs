using API.Controller;
using API.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plugin.Toast;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace API.ViewModels
{
    public class ProductoViewModels
    {
        RESTListView apirest = new RESTListView();

        public IList ProductosList { get; set; }

        public String ID { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Precio { get; set; }

        

        public ICommand SearchCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var response = await apirest.GetProductos();
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        JObject data = (JObject)JsonConvert.DeserializeObject<object>(content);
                        var productoCadena = data.Value<object>("data");
                        var productos = JsonConvert.DeserializeObject<Producto[]>(productoCadena.ToString());
                        ProductosList.Clear();
                        foreach(var item in productos)
                        {
                            ProductosList.Add(new Producto
                            {
                                Nombre = item.Nombre,
                                Descripcion = item.Descripcion,
                                Precio = item.Precio
                            });
                        }
                    }
                    else
                    {
                        CrossToastPopUp.Current.ShowToastError("No hay productos");
                    }
                });
            }

        }

        public ProductoViewModels()
        {
            ProductosList = new ObservableCollection<Producto>();
        }
    }
}
