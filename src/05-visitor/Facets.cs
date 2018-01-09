namespace Visitor {

    public enum Facets {
        Brand,
        Colour,
        Schema,
        Category
    }

    public class BaseFacet {
        public string label { get; set; }
        public string identifier { get; protected set; }
    }

    public class BrandFacet : BaseFacet {
        public BrandFacet () {
            this.identifier = Facets.Brand.ToString();
        }
    }

    public class ColourFacet : BaseFacet {
        public ColourFacet () {
            this.identifier = Facets.Colour.ToString();
        }
    }

    public class SchemaFacet : BaseFacet {
        public string schemaLabel { get; set; }
        public string schemaIdentifier { get; set; }
        public SchemaFacet () {
            this.identifier = Facets.Schema.ToString();
        }
    }

    public class CategoryFacet : BaseFacet {
        public CategoryFacet () {
            this.identifier = Facets.Category.ToString();
        }
    }
}
