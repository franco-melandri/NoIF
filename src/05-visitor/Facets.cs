namespace Visitor {

    public static class Facets {
        public const string Brand = "Brand";
        public const string Schema = "Schema";
    }

    public class BaseFacet {
        public string label { get; set; }
        public string identifier { get; protected set; }
    }

    public class BrandFacet : BaseFacet {
        public BrandFacet () {
            this.identifier = Facets.Brand;
        }
    }

    public class SchemaFacet : BaseFacet {
        public string schemaLabel { get; set; }
        public string schemaIdentifier { get; set; }
        public SchemaFacet () {
            this.identifier = Facets.Schema;
        }
    }
}
