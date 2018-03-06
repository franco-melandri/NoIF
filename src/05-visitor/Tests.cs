using NUnit.Framework;
using Visitor;

namespace Tests {
    
    [TestFixture]
    public class FacetTests
    {    
        [Test]
        public void ShouldFillBrandFacet() 
        {
            var sut = new BrandFacet{
                label = "brandLabel"
            };
            Assert.AreEqual(sut.identifier, "Brand");
            Assert.AreEqual(sut.label, "brandLabel");
        }
    
        [Test]
        public void ShouldFillSchemaFacet() 
        {
            var sut = new SchemaFacet{
                label = "label",
                schemaLabel = "schemaLabel",
                schemaIdentifier = "schemaIdentifier"
            };
            Assert.AreEqual(sut.identifier, "Schema");
            Assert.AreEqual(sut.label, "label");
            Assert.AreEqual(sut.schemaLabel, "schemaLabel");
            Assert.AreEqual(sut.schemaIdentifier, "schemaIdentifier");
        }
    }

    [TestFixture]
    public class RenderFacetTests
    {    
        [Test]
        public void ShouldRenderBrand() 
        {
            var facet = new BrandFacet{
                label = "label",
            };
            var sut = new RenderFacet();
            Assert.AreEqual(sut.Render(facet), "BRAND: label");
        }

        [Test]
        public void ShouldRenderSchema() 
        {
            var facet = new SchemaFacet{
                label = "label",
                schemaLabel = "schemaLabel",
                schemaIdentifier = "schemaIdentifier"
            };
            var sut = new RenderFacet();
            Assert.AreEqual(sut.Render(facet), "SCHEMA: label, schemaLabel, schemaIdentifier");
        }
    }

    [TestFixture]
    public class RenderFacetVisitorTests
    {    
        [Test]
        public void ShouldRenderBrand() 
        {
            var facet = new BrandFacetElement {
                label = "label",
            };
            var sut = new RenderFacetVisitor();
            Assert.AreEqual(sut.Render(facet), "BRAND: label");
        }

        [Test]
        public void ShouldRenderSchema() 
        {
            var facet = new SchemaFacetElement {
                label = "label",
                schemaLabel = "schemaLabel",
                schemaIdentifier = "schemaIdentifier"
            };
            var sut = new RenderFacetVisitor();
            Assert.AreEqual(sut.Render(facet), "SCHEMA: label, schemaLabel, schemaIdentifier");
        }
    }
}