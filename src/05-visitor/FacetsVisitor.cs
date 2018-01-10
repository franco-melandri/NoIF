namespace Visitor {

    public interface IBaseFacetElement {
        string visit(IVisitor visitor);
    }

    public class BrandFacetVisitor : BrandFacet,
                                     IBaseFacetElement {
        public string visit(IVisitor visitor) {
            return visitor.acceptBrand(this);
        }
    }

    public class SchemaFacetVisitor : SchemaFacet,
                                      IBaseFacetElement {
        public string visit(IVisitor visitor) {
            return visitor.acceptSchema(this);
        }
    }
}
