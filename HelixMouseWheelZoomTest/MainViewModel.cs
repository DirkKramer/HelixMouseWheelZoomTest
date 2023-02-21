using CommunityToolkit.Mvvm.ComponentModel;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixMouseWheelZoomTest
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
           

            // Init camera
            Camera = SetOrthographicCamera();


            // Init model
            var mesh = new MeshBuilder();
            mesh.AddBox(new Vector3(0, 0, 0), 2000, 2000, 2000);
            boxGeometry = mesh.ToMeshGeometry3D();
            boxMaterial = PhongMaterials.Red;

        }



        [ObservableProperty]
        double zoomSpeed;

        [ObservableProperty]
        Camera camera;

        [ObservableProperty]
        MeshGeometry3D boxGeometry;

        [ObservableProperty]
        Material boxMaterial;

        public Camera SetOrthographicCamera()
        {
            zoomSpeed = 1;
            return new OrthographicCamera
            {
                Position = new System.Windows.Media.Media3D.Point3D(155, -78, 136),
                LookDirection = new System.Windows.Media.Media3D.Vector3D(-160, 80, -140),
                UpDirection = new System.Windows.Media.Media3D.Vector3D(-0.5, 0.4, 0.75),
                FarPlaneDistance = 20000000,
                NearPlaneDistance = -20000000,
                Width = 240000
            };

        }
    }
}
