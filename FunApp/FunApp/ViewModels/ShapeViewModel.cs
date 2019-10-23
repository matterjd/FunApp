using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FunApp.Models;

namespace FunApp.ViewModels
{
    class ShapeViewModel
    {
        public ObservableCollection<Shape> Shapes { get; set; }

        public ShapeViewModel()
        {
            CreateShapeCollection();
        }

        async Task CreateShapeCollection()
        {
            Shapes.Add(new Shape
            {
                Name = "Square",
                Sides = 4,
                Description = "In geometry, a square is a regular quadrilateral, which means that it has four equal sides and four equal angles (90-degree angles, or (100-gradian angles or right angles). It can also be defined as a rectangle in which two adjacent sides have equal length.",
                ImageURL = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjnkK36tLDlAhUSP30KHa4yC0sQjRx6BAgBEAQ&url=https%3A%2F%2Fmathematicslounge.wordpress.com%2F2014%2F07%2F21%2Ffive-points-in-a-square%2F&psig=AOvVaw37IDwqHQEZE0j9myWqyleP&ust=1571852484334917"

            });

            await Task.Delay(2000);

            Shapes.Add(new Shape
            {
                Name = "Triangle",
                Sides = 3,
                Description = "A triangle is a polygon with three edges and three vertices. It is one of the basic shapes in geometry. A triangle with vertices A, B, and C is denoted . In Euclidean geometry any three points, when non-collinear, determine a unique triangle and simultaneously, a unique plane (i.e. a two-dimensional Euclidean space).",
                ImageURL = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjW8sC9tbDlAhXcIDQIHX_eDwwQjRx6BAgBEAQ&url=https%3A%2F%2Fmath.stackexchange.com%2Fquestions%2F538326%2Fcalculating-the-number-of-triangles&psig=AOvVaw3i4D2e9_DBFAgsc0DTLh6K&ust=1571852616297227"
            });

            await Task.Delay(2000);

            Shapes.Add(new Shape
            {
                Name = "Circle",
                Sides = 0,
                Description = "A circle is the locus of all points equidistant from a central point. Definitions Related to Circles. arc: a curved line that is part of the circumference of a circle. chord: a line segment within a circle that touches 2 points on the circle. circumference: the distance around the circle.",
                ImageURL = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwj59o3vtbDlAhXHITQIHVsRCgEQjRx6BAgBEAQ&url=https%3A%2F%2Fwildersoul.com%2F2016%2F04%2F29%2Flove-4%2F&psig=AOvVaw363GmK7Gzjn4xMh7EJrQ3z&ust=1571852694985401"
            });
        }
    }
}
