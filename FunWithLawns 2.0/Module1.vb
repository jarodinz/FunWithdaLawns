﻿Module Module1
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
        Console.SetCursorPosition(3, 1)
        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("Welcome " & company.ownersname)
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.SetCursorPosition(2, 3)
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░")
        Console.SetCursorPosition(3, 5)
        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("Total completed hours " & company.totalhours)
        Console.SetCursorPosition(3, 6)
        Console.WriteLine("Total Income: " & FormatCurrency(company.totalincome))
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.SetCursorPosition(2, 8)
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░")
    End Sub
    Class Client


        Public name As String
        Public address As String
        Public phone As Integer
        Public dates As Date
        Public time As Date
        Public complete As Boolean

    End Class


    Dim clients As New List(Of Client)

    Function Getbookings(complete As Boolean)
        Console.Clear()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Dim index As Integer = 0

        Console.WriteLine("Here's the Bookings currently in the program")
        Console.WriteLine()
        Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
        Console.WriteLine("=========================================================")



        For i = 0 To clients.Count - 1
            If clients(i).complete = complete Then
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))
            End If
        Next
        Console.WriteLine()
        Console.Write("Enter the index of the client: (-1 to cancel) ")
        index = Console.ReadLine
        Return index
    End Function

    Sub AddBooking()

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
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
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()
        If clients.Count = 0 Then
            Console.Clear()
            Console.WriteLine("You have no bookings")
        Else

            ' Dim index As Integer = Getbookings(False)

            Console.WriteLine("Here's the Bookings currently in the program")
            Console.WriteLine()
            Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
            Console.WriteLine("=========================================================")



            For i = 0 To clients.Count - 1

                If clients(i).complete = False Then
                    Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))

                End If
            Next

        End If
        Console.WriteLine("")

        Console.WriteLine("Press any key to continue")






        Console.ReadKey()
        Console.Clear()
    End Sub

    Sub ViewCompleteBookings()

        Console.Clear()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        '     Dim index As Integer = 0

        Console.WriteLine("Here's the Bookings currently in the program")
        Console.WriteLine()
        Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
        Console.WriteLine("=========================================================")



        For i = 0 To clients.Count - 1

            If clients(i).complete = True Then
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))
            End If
        Next
        Console.WriteLine("")

        Console.WriteLine("Press any key to continue...")

     

        Console.ReadKey()
    End Sub
    Sub Editcompany()

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("Current Company Details:")
        Console.WriteLine("")
        Console.WriteLine(" Owner: " & company.ownersname)
        Console.WriteLine(" Buisness name: " & company.buisnessname)
        Console.WriteLine(" Phone Number: " & company.number)

        Console.WriteLine(" Address: " & company.address)
        Console.WriteLine(" Hourly Rates: " & company.rate)
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Are these Correct (Y/N): ")

        Dim selection As Char
        selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
                Select selection
            Case "N"
                Console.Write("Owners Name: ")
                company.ownersname = Console.ReadLine

                Console.Write("Buisness Name: ")
                company.buisnessname = Console.ReadLine

            

                Console.Write("Phone Number : ")
                company.number = Console.ReadLine

                Console.Write("Owners Address: ")
                company.address = Console.ReadLine

                Console.Write("Hourly rates: $ ")
                company.rate = Console.ReadLine


                Console.WriteLine("Press any key to continue & return to menu")

                Console.ReadLine()
            Case "Y"

                Console.Clear()


                Console.WriteLine("Press any key to continue & return to menu")



                Console.ReadKey()


        End Select




    End Sub
    Sub IncompleteBookingsNext7()
        Console.Clear()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black

        If clients.Count = 0 Then
            Console.Clear()
            Console.WriteLine("You have no bookings")
        Else


            Console.WriteLine("Here's the Bookings currently in the program")
            Console.WriteLine()
            Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
            Console.WriteLine("=========================================================")



            For i = 0 To clients.Count - 1

                If clients(i).complete = False And clients(i).dates <= Now.AddDays(7) And clients(i).dates >= Now Then
                    Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))

                End If
            Next

        End If
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Press any key to continue")
        Console.ReadKey()
    End Sub


    Sub IncompleteBookingsdetails()


        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Dim index As Integer = Getbookings(False)
        Console.Clear()
        If index >= 0 And index < clients.Count Then
            Console.WriteLine("Here's the Incomplete Bookings details")
            Console.WriteLine("")
            Console.WriteLine("Clients name : " & clients(index).name)
            Console.WriteLine("")
            Console.WriteLine("Clients address : " & clients(index).address)
            Console.WriteLine("")
            Console.WriteLine("Clients phone : " & clients(index).phone)
            Console.WriteLine("")
            Console.WriteLine("Date of booking : " & clients(index).dates)
            Console.WriteLine("")
            Console.WriteLine("Time of booking : " & clients(index).time)
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("Enter any key to continue")

            Console.ReadKey()

        Else

            Dim selection As Char
            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select Case selection
                Case "-1"


            End Select
        End If
    End Sub


    Sub EditIncompletedetails()

        Console.Clear()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Dim index As Integer = Getbookings(False)


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

        Else
            Dim selection As Char
            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select selection
                Case "-1"

                    
            End Select

        End If
    End Sub



    Sub RemoveBooking()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()
        Console.WriteLine("Remove a Booking")
        Console.WriteLine("")
        Console.WriteLine("")

        Dim index As Integer = Getbookings(False)

        If index >= 0 And index < clients.Count Then

            'remove the student they choose
            Console.WriteLine("Do you want to remove this booking Y/N")

            Dim selection As Char
            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select Case selection
                Case "Y"

                    Console.WriteLine("Booking Removed")
                    clients.RemoveAt(index)
                    'completedclients.Add(newClient)
                    Console.ReadLine()
                Case "N"

                    Console.Clear()
                    Console.WriteLine("Canceled")
                    Console.WriteLine("Press any key to continue")
                    Console.ReadKey()
            End Select
        End If


        Console.WriteLine("Booking removed")

    End Sub



    Sub CompleteBooking()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Dim index As Integer = Getbookings(False)
        Dim newClient As New Client
        If index >= 0 And index < clients.Count Then

            Console.WriteLine("Do you want to complete this bookng (y/n): ")
            Dim selection As Char
            selection = Console.ReadKey(True).KeyChar.ToString.ToUpper
            Select Case selection

                Case "Y"

                    

                    Console.Write("How many hours did it take to do the job: ")
                    company.totalhours += Console.ReadLine

                    company.totalincome = company.totalhours * company.rate

                    Console.WriteLine("Booking Completed")
                    clients(index).complete = True



                    Console.ReadLine()
                Case "N"

                    Console.Clear()

            End Select
        End If

    End Sub

    Sub BuisnessCard()
        Console.Clear()

        Console.ForegroundColor = ConsoleColor.Black

        Console.SetCursorPosition(13, 5)
        Console.WriteLine("╔══════════════════════════════════════════╗")

        Console.SetCursorPosition(13, 15)
        Console.WriteLine("╚══════════════════════════════════════════╝")


        Console.SetCursorPosition(13, 7)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 9)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 10)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 6)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 8)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 11)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 12)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 13)
        Console.WriteLine("║")
        Console.SetCursorPosition(13, 14)
        Console.WriteLine("║")


        Console.SetCursorPosition(56, 7)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 9)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 10)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 6)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 8)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 11)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 12)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 13)
        Console.WriteLine("║")
        Console.SetCursorPosition(56, 14)
        Console.WriteLine("║")


       
        Console.SetCursorPosition(16, 9)
        Console.WriteLine("Owner: " & company.ownersname)
        Console.SetCursorPosition(16, 6)
        Console.WriteLine(company.buisnessname)
        Console.SetCursorPosition(16, 11)
        Console.WriteLine("Phone Number: " & company.number)
        Console.SetCursorPosition(16, 13)
        Console.WriteLine("Address: " & company.address)

        Console.ReadKey()
    End Sub
    Sub menu()
        Dim selection As Char






        Do
            

            Companyinfo()
            Console.BackgroundColor = ConsoleColor.Gray
            Console.ForegroundColor = ConsoleColor.Black



            Console.SetCursorPosition(3, 10)
            Console.WriteLine("Select from one of the following menu options:")
            Console.SetCursorPosition(1, 13)
            Console.WriteLine("  (A) Add a booking")
            Console.SetCursorPosition(1, 14)
            Console.WriteLine("  (B) View all incomplete bookings")
            Console.SetCursorPosition(1, 15)
            Console.WriteLine("  (C) View all complete bookings")
            Console.SetCursorPosition(1, 16)
            Console.WriteLine("  (D) Check incomplete bookings for next 7 days")
            Console.SetCursorPosition(1, 17)
            Console.WriteLine("  (E) View incomplete booking's details")
            Console.SetCursorPosition(1, 18)
            Console.WriteLine("  (F) Edit incomplete booking details ")
            Console.SetCursorPosition(1, 20)
            Console.WriteLine("  (G) Remove a booking")
            Console.SetCursorPosition(1, 22)
            Console.WriteLine("  (H) Complete a booking")
            Console.SetCursorPosition(1, 24)
            Console.WriteLine("  (I) View Buisness card")
            Console.SetCursorPosition(1, 25)
            Console.WriteLine("  (J) Edit Your Companies Information")
            Console.SetCursorPosition(1, 28)
            Console.WriteLine("  (X) Save and Exit")
            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.SetCursorPosition(0, 0)
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗")


            Console.SetCursorPosition(0, 30)

            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝")

            Console.SetCursorPosition(0, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 5)

            Console.WriteLine("║")
            Console.SetCursorPosition(0, 1)
            Console.WriteLine("║")

            Console.SetCursorPosition(0, 3)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 2)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 4)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 7)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 9)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 10)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 8)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 11)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 12)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 13)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 14)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 15)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 16)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 17)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 18)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 19)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 20)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 21)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 22)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 23)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 24)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 25)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 26)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 27)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 28)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 29)
            Console.WriteLine("║")



            Console.SetCursorPosition(79, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 5)

            Console.WriteLine("║")
            Console.SetCursorPosition(79, 1)
            Console.WriteLine("║")
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 3)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 2)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 4)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 7)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 9)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 10)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 8)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 11)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 12)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 13)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 14)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 15)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 16)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 17)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 18)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 19)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 20)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 21)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 22)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 23)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 24)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 25)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 26)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 27)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 28)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 29)
            Console.WriteLine("║")
           



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
                Case "J"
                    Editcompany()

            End Select
            'Console.Clear()
        Loop Until selection = "X"
        Save()

        Console.Clear()
        Dim savingword As String = "Saving"
        Dim Saving As Integer
        Dim finished As Boolean = False
        Dim rand As New Random
        Dim delaycount As Integer = rand.Next(0, 30)
        Dim count As Integer = 0

    

        While Not finished

            'slow down
            Threading.Thread.Sleep(20)

            Console.SetCursorPosition(Saving + 34, 10)
            Console.BackgroundColor = ConsoleColor.Red

            'put down 10 random numbers
            For i = Saving To 5
                Console.Write(savingword(i))

            Next

            count += 1

            'check if we hit the threshold

            If count = delaycount Then
                Console.BackgroundColor = ConsoleColor.Green
                Console.SetCursorPosition(Saving + 34, 10)
                Console.Write(savingword(Saving))


                Saving += 1
                count = 0
                delaycount = rand.Next(0, 30)



            End If










            If Saving = 6 Then
                finished = True
                Console.BackgroundColor = ConsoleColor.Black
            End If





        End While










        Console.SetCursorPosition(Saving + 28, 10)
        Console.BackgroundColor = ConsoleColor.Green

        Console.WriteLine("GoodBye")
        Threading.Thread.Sleep(1140)


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


        FileOpen(1, "ClientsData.txt", OpenMode.Output)

        For i = 0 To clients.Count - 1


            'fill the file
            PrintLine(1, clients(i).name)
            PrintLine(1, clients(i).address)
            PrintLine(1, clients(i).phone)
            PrintLine(1, clients(i).dates)
            PrintLine(1, clients(i).time)
            PrintLine(1, clients(i).complete)
        Next

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


        If IO.File.Exists("ClientsData.txt") Then


            'open file for reading
            FileOpen(1, "ClientsData.txt", OpenMode.Input)

            'while we are not at the end of the file
            While Not EOF(1)
                Dim Newclient As New Client

                Newclient.name = LineInput(1)
                Newclient.address = LineInput(1)
                Newclient.phone = LineInput(1)
                Newclient.dates = LineInput(1)
                Newclient.time = LineInput(1)
                Newclient.complete = LineInput(1)





                clients.Add(Newclient)


            End While




            'choose our file
            FileClose(1)
        End If

    End Sub
    Sub title()
        Console.BackgroundColor = ConsoleColor.Gray
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()



        If IO.File.Exists("Companydata.txt") Then
            Console.Clear()
            Console.SetCursorPosition(16, 2)
            Console.WriteLine("Welcome to Fun With Lawns v0.2. New and Better!")
            Console.SetCursorPosition(19, 4)
            Console.WriteLine("Your all in one Lawn Management System ")
        
            Console.WriteLine("")
            Console.SetCursorPosition(28, 10)
            Console.WriteLine("Todays Appointments")


            If clients.Count <= 0 Then

                Console.WriteLine("You have no bookings")
            Else


                Console.WriteLine()
                Console.SetCursorPosition(10, 12)
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", "ID", "Clients Name", "Date", "Time")
                Console.SetCursorPosition(10, 13)
                Console.WriteLine("=========================================================")



                For i = 0 To clients.Count - 1

                    If clients(i).complete = False And clients(i).dates <= Now.AddDays(1) And clients(i).dates >= Now.AddDays(-1) Then
                        Console.SetCursorPosition(10, 14)
                        Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-15}", i, clients(i).name, clients(i).dates.ToString("dd/MM/yy"), clients(i).time.ToString("hh:mm tt"))

                    End If
                Next

            End If
            'Console.SetCursorPosition(0, 28)
            'Console.SetCursorPosition(0, 0)
            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.SetCursorPosition(0, 0)
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗")
            

            Console.SetCursorPosition(0, 27)

            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝")
           
            Console.SetCursorPosition(0, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 5)

            Console.WriteLine("║")
            Console.SetCursorPosition(0, 1)
            Console.WriteLine("║")

            Console.SetCursorPosition(0, 3)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 2)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 4)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 7)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 9)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 10)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 8)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 11)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 12)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 13)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 14)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 15)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 16)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 17)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 18)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 19)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 20)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 21)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 22)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 23)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 24)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 25)
            Console.WriteLine("║")
            Console.SetCursorPosition(0, 26)
            Console.WriteLine("║")
           

            Console.SetCursorPosition(79, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 5)

            Console.WriteLine("║")
            Console.SetCursorPosition(79, 1)
            Console.WriteLine("║")
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 3)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 2)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 4)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 7)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 9)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 10)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 6)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 8)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 11)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 12)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 13)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 14)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 15)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 16)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 17)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 18)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 19)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 20)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 21)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 22)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 23)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 24)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 25)
            Console.WriteLine("║")
            Console.SetCursorPosition(79, 26)
            Console.WriteLine("║")




            Console.ForegroundColor = ConsoleColor.Black
            Console.SetCursorPosition(21, 19)
            Console.Write("Press and key to continue...")

            Console.ReadKey()
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
            Console.Write("Press any key to continue")
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

    End Sub
  











    Sub Main()
        Load()
        title()
        menu()
    End Sub

End Module
