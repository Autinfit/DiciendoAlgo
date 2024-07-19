# DiciendoAlgo

- **_Ésta es la solución del programa hasta el momento._**
- **_Ahora podemos comenzar a agregar algunos eventos a la aplicación._**
- **_Cuando usted abra el programa por primera vez, éste debería tener el archivo en formato .cs abierto; Sin embargo, si no lo abrió, puedes hacer doble clic en él desde el explorador de soluciones._**
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace hello_WPF
{
///<summary>
/// Interaction logic for MainWindow.xaml
///</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
            {
                InitializeComponent();
            }
    }
}
```
- **_Ésta es la solución predeterminada de nuestro archivo por C# en esta aplicación._**
- **_Éste es la solución vacía por ahora ya que comenzaremos a agregar nuestras propias funciones._**
- **_Lo primero que debemos hacer es volver al archivo XML y agregar algunas etiquetas rápidas._**
```
<Windowx:Class="hello_WPF.MainWindow" 
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
xmlns:local="clr-namespace:hello_WPF"
mc:Ignorable="d"
Title="MainWindow" Background="Black" Height="350" Width="525">
<Grid>
<Button VerticalAlignment="Bottom" Height="20" Width="200" Content="Click ME" FontWeight="Bold" Click="Button_MouseDown">
</Button>
<TextBlock Name="hi" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="72" Foreground="Yellow">
Hello, MARSFOREVER!
</TextBlock>
</Grid>
</Window>
```
