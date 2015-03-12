Module Module1
    Class cCompany
        Public buisnessname As String
        Public ownersname As String
        Public number As String
        Public address As String
        Public rate As Single
        Public totalhours As Integer
        Public totalincome As Single
    End Class

    Dim company As New cCompany
    Sub Companyinfo()

        Console.Clear()

        Console.WriteLine("Welcome " & company.buisnessname)
        Console.WriteLine("=====================================================================")
        Console.WriteLine("Total completed hours " & company.totalhours)

        Console.WriteLine("Total Income: " & company.totalincome)

    End Sub
    Class Client

        Public name As String
        Public address As String
        Public phone As Integer
        Public dates As Date
        Public time As Date
        Public complete As Boolean

    End Class
    ' Dim completedclients As New List(Of Client)

    Dim clients As New List(Of Client)

    Function Getbookings()
        Console.Clear()

        Dim index As Integer = 0

        Console.WriteLine("Here's the Bookings currently in the program")
        Console.WriteLine()
        Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
        Console.WriteLine("=========================================================")



        For i = 0 To clients.Count - 1

            Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))

        Next
        Console.WriteLine()
        Console.Write("Enter the index of the client: ")
        index = Console.ReadLine
        Return index
    End Function

    Sub AddBooking()

        Dim newClient As New Client

        Console.Clear()
        Console.WriteLine("I'm going to add a Booking")

        Console.Write("Clients Name: ")
        newClient.name = Console.ReadLine

        Console.Write("Clients Address: ")
        newClient.address = Console.ReadLine

        Console.Write("Clients Number: ")
        newClient.phone = Console.ReadLine

        Console.Write("Date of the booking (dd/mm/yy): ")
        newClient.dates = Console.ReadLine

        Console.Write("Time of the Booking: (hh:mm am/pm)")
        newClient.time = Console.ReadLine

        Console.WriteLine("You added a Booking!")

        'add to list

        ' clients.Add(newClient)

        Console.Clear()


        Console.WriteLine("Booking Details are as followed: ")

        
        Console.WriteLine("Clients Name: " & newClient.name)
        Console.WriteLine("Clients Address: " & newClient.address)
        Console.WriteLine("Clients Phone: " & newClient.phone)
        Console.WriteLine("Date of booking: " & newClient.dates)
        Console.WriteLine("Time of booking: " & newClient.time)


        Console.Write("Are these Correct (Y/N): ")
        Dim selection As Char
        selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
        Select Case selection
            Case "Y"
                clients.Add(newClient)
                Console.WriteLine("Booking added")

                Console.ReadLine()
            Case "N"
                clients.Remove(newClient)
                Console.Clear()

        End Select

        Console.Clear()

    End Sub












    Sub ViewIncompletebookings()


        If clients.Count = 0 Then
            Console.Clear()
            Console.WriteLine("You have no bookings")
        Else
            Dim index As Integer = Getbookings()


            Console.WriteLine("Here's all the Incomplete Bookings")
            Console.WriteLine("Clients name :" & clients(index).name)
            Console.WriteLine("Clients address :" & clients(index).address)
            Console.WriteLine("Clients phone :" & clients(index).phone)
            Console.WriteLine("Date of booking :" & clients(index).dates)
            Console.WriteLine("Time of booking :" & clients(index).time)



        End If


        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub ViewCompleteBookings()
        ' Dim index As Integer = Getbookings()
        '  Dim completedbooking As New Client
        ' If index >= 0 And index < clients.Count Then

        ' End If



    End Sub

    Sub IncompleteBookingsNext7()

    End Sub


    Sub IncompleteBookingsdetails()

    End Sub


    Sub EditIncompletedetails()
        Console.Clear()
        Dim index As Integer = Getbookings()

        If index >= 0 And index < clients.Count Then
            'get their first name

            Console.Write("Clients name: ")
            clients(index).name = Console.ReadLine

            Console.Write("Clients address: ")
            clients(index).address = Console.ReadLine

            Console.Write("Clients phone: ")
            clients(index).phone = Console.ReadLine

            Console.Write("Date of Booking (dd/mm/yy): ")
            clients(index).dates = Console.ReadLine

            Console.Write("Time of Booking (hh:mm am/pm): ")
            clients(index).time = Console.ReadLine

            Console.Clear()
        End If
    End Sub



    Sub RemoveBooking()

    End Sub



    Sub CompleteBooking()
        Dim index As Integer = Getbookings()
        Dim newClient As New Client
        If index >= 0 And index < clients.Count Then

            Console.WriteLine("Do you want to complete this bookng (y/n): ")
            Dim selection As Char
            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select Case selection
                Case "Y"

                    Console.WriteLine("Booking Completed")
                    'completedclients.Add(newClient)
                    Console.ReadLine()
                Case "N"

                    Console.Clear()

            End Select
        End If

    End Sub

    Sub BuisnessCard()
        Console.Clear()
        Console.WriteLine("Owner: " & company.ownersname)
        Console.WriteLine("Company: " & company.buisnessname)
        Console.WriteLine("Phone Number: " & company.number)
        Console.WriteLine("Address: " & company.address)

        Console.ReadLine()
    End Sub
    Sub menu()
        Dim selection As Char

        Do
            Console.Clear()
            Companyinfo()


            Console.SetCursorPosition(1, 7)
            Console.WriteLine("Select from one of the following menu options:")
            Console.SetCursorPosition(1, 9)
            Console.WriteLine("  (A) Add a booking")
            Console.SetCursorPosition(1, 10)
            Console.WriteLine("  (B) View all incomplete bookings")
            Console.SetCursorPosition(1, 11)
            Console.WriteLine("  (C) View all complete bookings")
            Console.SetCursorPosition(1, 12)
            Console.WriteLine("  (D) Check incomplete bookings for next 7 days")
            Console.SetCursorPosition(1, 14)
            Console.WriteLine("  (E) View incomplete booking's details")
            Console.SetCursorPosition(1, 15)
            Console.WriteLine("  (F) Edit incomplete booking details ")
            Console.SetCursorPosition(1, 17)
            Console.WriteLine("  (G) Remove a booking")
            Console.SetCursorPosition(1, 18)
            Console.WriteLine("  (H) Complete a booking")
            Console.SetCursorPosition(1, 20)
            Console.WriteLine("  (I) View Buisness car")
            Console.SetCursorPosition(1, 22)
            Console.WriteLine("  (X) Exit")




            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select Case selection
                Case "A"
                    AddBooking()
                Case "B"
                    ViewIncompletebookings()
                Case "C"
                    ViewCompleteBookings()
                Case "D"
                    IncompleteBookingsNext7()
                Case "E"
                    IncompleteBookingsdetails()
                Case "F"
                    EditIncompletedetails()
                Case "G"
                    RemoveBooking()
                Case "H"
                    CompleteBooking()
                Case "I"
                    BuisnessCard()

            End Select
            'Console.Clear()
        Loop Until selection = "X"
        Save()

    End Sub

    Sub Save()

        FileOpen(1, "Companydata.txt", OpenMode.Output)
        PrintLine(1, company.buisnessname)
        PrintLine(1, company.ownersname)
        PrintLine(1, company.number)
        PrintLine(1, company.rate)
        PrintLine(1, company.totalhours)
        PrintLine(1, company.totalincome)
        PrintLine(1, company.address)




        FileClose(1)


    End Sub


    Sub Load()

        If IO.File.Exists("Companydata.txt") Then


            'open file for reading
            FileOpen(1, "Companydata.txt", OpenMode.Input)

            'while we are not at the end of the file


            company.buisnessname = LineInput(1)
            company.ownersname = LineInput(1)
            company.number = LineInput(1)
            company.rate = LineInput(1)
            company.totalhours = LineInput(1)
            company.totalincome = LineInput(1)
            company.address = LineInput(1)








            FileClose(1)

        End If

    End Sub
    Sub title()

        If IO.File.Exists("Companydata.txt") Then
            Console.Clear()

        Else



            'Title
            Console.SetCursorPosition(16, 0)
            Console.WriteLine("Welcome to Fun With Lawns v0.2. New and Better!")
            Console.SetCursorPosition(19, 2)
            Console.WriteLine("Your all in one Lawn Management System ")
            Console.SetCursorPosition(25, 8)
            Console.WriteLine("Press and key to continue...")

            Console.ReadKey()
            Console.Clear()

            Console.Write("No company information has been found. We'll setup a profile before we begin")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue")
            Console.ReadKey()
            Console.Clear()
            Console.WriteLine("Here you need to enter the details for your new company profile")

            Console.Write("Buisness Name: ")
            company.buisnessname = Console.ReadLine

            Console.Write("Owners Name: ")
            company.ownersname = Console.ReadLine

            Console.Write("Phone Number Name: ")
            company.number = Console.ReadLine

            Console.Write("Owners Address: ")
            company.address = Console.ReadLine

            Console.Write("Hourly rates: $ ")
            company.rate = Console.ReadLine

            Console.WriteLine()
            Console.WriteLine("Setup is Complete")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue....")
            Console.ReadKey()
        End If
        menu()
    End Sub
  











    Sub Main()
        Load()
        title()
        menu()
    End Sub

End Module
