namespace Visitor {

    public interface IElement {
        string accept(IVisitor visitor);
    }

    public class BrandFacetElement : BrandFacet,
                                     IElement {
        public string accept(IVisitor visitor) {
            return visitor.visit(this);
        }
    }

    public class SchemaFacetElement : SchemaFacet,
                                      IElement {
        public string accept(IVisitor visitor) {
            return visitor.visit(this);
        }
    }
}
