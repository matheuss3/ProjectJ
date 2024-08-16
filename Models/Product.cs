using ProjectJ.Dao;

namespace ProjectJ.Models
{
    public class Product: IGenericModel<Product>
    {
        #region "Atributos"
        private int id;
        private string name;
        private DateTime? creationDate;
        private decimal price;
        private string description;
        #endregion
        
        #region "Propriedades"
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime? CreationDate { get { return creationDate; } 
                                        set { 
                                            if (value == null)
                                            {
                                                value = DateTime.Now;
                                            }
                                            creationDate = value; } }
        public decimal Price { get { return price; } set { price = value; } }  
        public string Description { get { return description; } set { description = value; } }
        #endregion

        public List<Product> get()
        {
            return DaoProduct.get();
        }

        public Product post()
        {
            return DaoProduct.post(this);
        }

        public Product update()
        {
            try
            {
                DaoProduct.update(this);
                return this;
            } catch (Exception) 
            {
                throw;
            }

            
        }

        public bool delete()
        {
            try
            {
                return DaoProduct.delete(this);
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
