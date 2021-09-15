Module Module1
    Sub Main()

        Dim car1 As New car()
        With car1
            .Carname = "BMW M3"
            .Engine = "S50"
            .Carbodystyle = "2-дв. купе (4-мест.)"
            .Typeofcar = "car"
            .Carclass = "S class"
        End With
        car1.Display()
        Dim truck1 As New truck()
        With truck1
            .Carname = "Mercedes-Benz Actros"
            .Engine = "6-цилиндровые 12 л"
            .Carbodystyle = "Tractor Unit"
            .Typeofcar = "truck"
            .Cabtype = "Удлиненная кабина Actros (L) с одиночной кабиной с низкой крышей"
        End With
        truck1.Display()

        Console.ReadKey()
    End Sub
    Class Auto
        Dim _Carname As String
        Dim _Engine As String
        Dim _Carbodystyle As String
        Dim _Typeofcar As String
        Public Property Carname() As String 'Двигатель
            Get
                Return _Carname
            End Get
            Set(value As String)
                _Carname = value
            End Set
        End Property
        Public Property Engine() As String 'Двигатель
            Get
                Return _Engine
            End Get
            Set(value As String)
                _Engine = value
            End Set
        End Property

        Public Property Carbodystyle() As String 'Тип кузова
            Get
                Return _Carbodystyle
            End Get
            Set(value As String)
                _Carbodystyle = value
            End Set
        End Property
        Public Property Typeofcar() As String 'Тип автомобиля(легковой или грузовик)
            Get
                Return _Typeofcar
            End Get
            Set(value As String)
                _Typeofcar = value
            End Set
        End Property
        Public Overridable Sub Display()
            Console.WriteLine($"Name:{Carname}; Engine:{Engine}; Car body style:{Carbodystyle}; Type of car:{Typeofcar}")
        End Sub

    End Class
    Class car 'легковая
        Inherits Auto
        Public Property Carclass As String 'Класс легкового автомобиля
        Public Overrides Sub Display()
            Console.WriteLine($"Name:{Carname}; Engine:{Engine}; Car body style:{Carbodystyle}; Type of car:{Typeofcar}; Class of car:{Carclass}")
        End Sub
    End Class
    Class truck 'грузовик
        Inherits Auto
        Public Property Cabtype As String 'Тип кабины грузовика
        Public Overrides Sub Display()
            Console.WriteLine($"Name:{Carname}; Engine:{Engine}; Car body style:{Carbodystyle}; Type of car:{Typeofcar}; Type of cab:{Cabtype}")
        End Sub
    End Class
End Module
