
Public Class Main2

    Private dtElements As DataTable
    Private TEMPBIO_FOLDER As String = "TempBio"
    Private REWRITEBIO_FOLDER As String = "ReWriteBio"

    Private CardPIN As String = "123456"

    Private sc As UMIDLibrary.AllCardTech_Smart_Card
    Private _sagem As SagemCapturingDLL.Sagem

    Private Live_Lprimary As String = REWRITEBIO_FOLDER & "\Live_Lprimary.ansi-fmr"
    Private Live_Rprimary As String = REWRITEBIO_FOLDER & "\Live_Rprimary.ansi-fmr"
    Private Live_Lbackup As String = REWRITEBIO_FOLDER & "\Live_Lbackup.ansi-fmr"
    Private Live_Rbackup As String = REWRITEBIO_FOLDER & "\Live_Rbackup.ansi-fmr"

    Private Card_Lprimary As String = TEMPBIO_FOLDER & "\Card_Lprimary.ansi-fmr"
    Private Card_Rprimary As String = TEMPBIO_FOLDER & "\Card_Rprimary.ansi-fmr"
    Private Card_Lbackup As String = TEMPBIO_FOLDER & "\Card_Lbackup.ansi-fmr"
    Private Card_Rbackup As String = TEMPBIO_FOLDER & "\Card_Rbackup.ansi-fmr"

    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid.AutoGenerateColumns = False
        dtElements = New DataTable
        dtElements.Columns.Add("Code", GetType(Int16))
        dtElements.Columns.Add("ElementName", GetType(String))
        dtElements.Columns.Add("ElementValue", GetType(String))
        dtElements.Columns.Add("SecurityLevel", GetType(Int16))
        PopulateElement()
        grid.DataSource = dtElements

        InitializeSC()
    End Sub

    Private Sub InitializeSC()
        If sc Is Nothing Then
            Try
                WriteToRTB("SC initialization success")
            Catch ex As Exception
                WriteToRTB("SC initialization failed")
            End Try
            sc = New UMIDLibrary.AllCardTech_Smart_Card
            sc.InitializeReaders()
        End If
    End Sub

    Private Sub PopulateElement()
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CRN, "CRN", "", 0)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CSN, "CSN", "", 0)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_CREATION_DATE, "CREATION DATE", "", 0)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_STATUS, "CARD STATUS", "", 0)

        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FIRST_NAME, "FIRST NAME", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MIDDLE_NAME, "MIDDLE NAME", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LAST_NAME, "LAST NAME", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.SUFFIX, "SUFFIX", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.GENDER, "GENDER", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.DATE_OF_BIRTH, "DATE OF BIRTH", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_ROOM_OR_FLOOR_OR_UNIT_NO_AND_BUILDING_NAME, "ROOM/FLOOR/UNIT/BLDG", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_HOUSE_OR_LOT_AND_BLOCK_NUMBER, "HOUSE/LOT/BLOCK", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_STREET_NAME, "STREET", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_SUBDIVISION, "SUBDIVISION", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_BARANGAY_OR_DISTRIC_OR_LOCALITY, "BARANGAY", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_CITY_OR_MUNICIPALITY, "CITY", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_PROVINCIAL_OR_STATE, "PROVINCE", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_COUNTRY, "COUNTRY", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_POSTAL_CODE, "POSTAL", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.HEIGHT, "HEIGHT", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.WEIGHT, "WEIGHT", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_PRIMARY_FINGER_CODE, "LEFT PRIMARY CODE", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_PRIMARY_FINGER_CODE, "RIGHT PRIMARY CODE", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_SECONDARY_FINGER_CODE, "LEFT BACKUP CODE", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_SECONDARY_FINGER_CODE, "RIGHT BACKUP CODE", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_PRIMARY_FINGER, "LEFT PRIMARY FINGER", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_PRIMARY_FINGER, "RIGHT PRIMARY FINGER", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_SECONDARY_FINGER, "LEFT BACKUP FINGER", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_SECONDARY_FINGER, "RIGHT BACKUP FINGER", "", 1)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_PICTURE, "PHOTO", "", 1)

        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS, "MARITAL STATUS", "", 2)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.PIN, "PIN", "", 2)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE, "SIGNATURE", "", 2)

        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_1, "GSIS 1", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_2, "GSIS 2", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_3, "GSIS 3", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_4, "GSIS 4", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_5, "GSIS 5", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_6, "GSIS 6", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_7, "GSIS 7", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_8, "GSIS 8", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_9, "GSIS 9", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_10, "GSIS 10", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_11, "GSIS 11", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_12, "GSIS 12", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_13, "GSIS 13", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_14, "GSIS 14", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_15, "GSIS 15", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_16, "GSIS 16", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_17, "GSIS 17", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_18, "GSIS 18", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_19, "GSIS 19", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_20, "GSIS 20", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_21, "GSIS 21", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_22, "GSIS 22", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_23, "GSIS 23", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_24, "GSIS 24", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_25, "GSIS 25", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_26, "GSIS 26", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_27, "GSIS 27", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_28, "GSIS 28", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_29, "GSIS 29", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_30, "GSIS 30", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_31, "GSIS 31", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_32, "GSIS 32", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_33, "GSIS 33", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_34, "GSIS 34", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_35, "GSIS 35", "", Nothing)
        AddRow(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_36, "GSIS 36", "", Nothing)
    End Sub

    Private Sub ReadCard()
        Me.Enabled = False
        Cursor = Cursors.WaitCursor

        If System.IO.Directory.Exists(TEMPBIO_FOLDER) Then System.IO.Directory.Delete(TEMPBIO_FOLDER, True)

        System.IO.Directory.CreateDirectory(TEMPBIO_FOLDER)

        For Each rw As DataRow In dtElements.Rows
            If Not rw("ElementName").ToString.Contains("GSIS") Then
                Select Case CType(rw("Code"), UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields)
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CRN
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CRN))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CSN
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CSN))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_CREATION_DATE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_CREATION_DATE))
                    'Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_STATUS
                    '    Dim result As Boolean = sc.getUmidFile(TEMPBIO_FOLDER & "\Card_Signature.tiff", UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)
                    '    If Not result Then
                    '        dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)(0)("ElementValue") = "<failed>"
                    '    Else
                    '        dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)(0)("ElementValue") = "<click to locate signature>"
                    '    End If

                    '    dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS)(0)("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS))

                    '    Dim status As String = ""
                    '    sc.GetCardStatus(status)
                    '    rw("ElementValue") = status
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FIRST_NAME
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FIRST_NAME))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MIDDLE_NAME
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MIDDLE_NAME))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LAST_NAME
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LAST_NAME))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.SUFFIX
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.SUFFIX))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.GENDER
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.GENDER))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.DATE_OF_BIRTH
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.DATE_OF_BIRTH))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_ROOM_OR_FLOOR_OR_UNIT_NO_AND_BUILDING_NAME
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_ROOM_OR_FLOOR_OR_UNIT_NO_AND_BUILDING_NAME))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_HOUSE_OR_LOT_AND_BLOCK_NUMBER
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_HOUSE_OR_LOT_AND_BLOCK_NUMBER))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_STREET_NAME
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_STREET_NAME))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_SUBDIVISION
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_SUBDIVISION))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_BARANGAY_OR_DISTRIC_OR_LOCALITY
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_BARANGAY_OR_DISTRIC_OR_LOCALITY))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_CITY_OR_MUNICIPALITY
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_CITY_OR_MUNICIPALITY))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_PROVINCIAL_OR_STATE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_PROVINCIAL_OR_STATE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_COUNTRY
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_COUNTRY))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_POSTAL_CODE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_POSTAL_CODE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.HEIGHT
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.HEIGHT))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.WEIGHT
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.WEIGHT))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_PRIMARY_FINGER_CODE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_PRIMARY_FINGER_CODE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_PRIMARY_FINGER_CODE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_PRIMARY_FINGER_CODE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_SECONDARY_FINGER_CODE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_SECONDARY_FINGER_CODE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_SECONDARY_FINGER_CODE
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_SECONDARY_FINGER_CODE))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_PRIMARY_FINGER
                        Dim result As Boolean = sc.getUmidFile(Card_Lprimary, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_PRIMARY_FINGER)
                        If Not result Then
                            rw("ElementValue") = "<failed>"
                        Else
                            rw("ElementValue") = "<click to locate left primary fingerprint>"
                        End If
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_PRIMARY_FINGER
                        Dim result As Boolean = sc.getUmidFile(Card_Rprimary, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_PRIMARY_FINGER)
                        If Not result Then
                            rw("ElementValue") = "<failed>"
                        Else
                            rw("ElementValue") = "<click to locate right primary fingerprint>"
                        End If
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_SECONDARY_FINGER
                        Dim result As Boolean = sc.getUmidFile(Card_Lbackup, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_SECONDARY_FINGER)
                        If Not result Then
                            rw("ElementValue") = "<failed>"
                        Else
                            rw("ElementValue") = "<click to locate left secondary fingerprint>"
                        End If
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_SECONDARY_FINGER
                        Dim result As Boolean = sc.getUmidFile(Card_Rbackup, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_SECONDARY_FINGER)
                        If Not result Then
                            rw("ElementValue") = "<failed>"
                        Else
                            rw("ElementValue") = "<click to locate right secondary fingerprint>"
                        End If
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_PICTURE
                        Dim result As Boolean = sc.getUmidFile(TEMPBIO_FOLDER & "\Card_Photo.jpg", UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_PICTURE)
                        If Not result Then
                            rw("ElementValue") = "<failed>"
                        Else
                            rw("ElementValue") = "<click to locate photo>"
                        End If
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS))
                    Case UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.PIN
                        rw("ElementValue") = "<not extractable>"
                End Select
            Else
                Select Case CType(rw("Code"), UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS)
                    Case UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_11
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getGSISData(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_11, 0, 10))
                    Case UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_12
                        rw("ElementValue") = Util.ByteArrayToAscii(sc.getGSISData(UMIDLibrary.AllCardTech_Smart_Card.GSIS_FIELDS.GSIS_12, 0, 11))
                End Select
            End If
        Next

        If dtElements.Select("ElementName='CARD STATUS'").Length > 0 Then
            Dim rw As DataRow = dtElements.Select("ElementName='CARD STATUS'")(0)
            Dim result As Boolean = sc.getUmidFile(TEMPBIO_FOLDER & "\Card_Signature.tiff", UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)
            If Not result Then
                dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)(0)("ElementValue") = "<failed>"
            Else
                dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)(0)("ElementValue") = "<click to locate signature>"
            End If

            dtElements.Select("Code=" & UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS)(0)("ElementValue") = Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS))

            Dim status As String = ""
            sc.GetCardStatus(status)
            rw("ElementValue") = status
        End If

        grid.DataSource = dtElements

        Dim sbOutput As New System.Text.StringBuilder
        For Each rw2 As DataRow In dtElements.Rows
            sbOutput.Append(rw2("ElementName").ToString & ": " & rw2("ElementValue").ToString & vbNewLine)
        Next

        IO.File.WriteAllText(Application.StartupPath & "\SAM_SN02612598_" & Now.ToString("hhmmss") & ".txt", sbOutput.ToString)

        ChangeGridForeColor()

        Me.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub AddRow(ByVal Code As Integer, ByVal ElementName As String, ByVal ElementValue As String, ByVal SecurityLevel As String)
        Dim rw As DataRow = dtElements.NewRow
        rw(0) = Code
        rw(1) = ElementName
        rw(2) = ElementValue
        If SecurityLevel = Nothing Then
            rw(3) = DBNull.Value
        Else
            rw(3) = SecurityLevel
        End If

        dtElements.Rows.Add(rw)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        sc.DisconnectApplet()
        sc = Nothing

        If System.IO.Directory.Exists(TEMPBIO_FOLDER) Then
            System.IO.Directory.Delete(TEMPBIO_FOLDER, True)
            System.IO.Directory.CreateDirectory(TEMPBIO_FOLDER)
        End If

        dtElements.Clear()
        PopulateElement()

        btnSelectApplet.BackColor = DefaultBackColor
        btnAuthentication1.BackColor = DefaultBackColor
        btnAuthentication2.BackColor = DefaultBackColor

        InitializeSC()
    End Sub

    Private Sub btnSelectApplet_Click(sender As Object, e As EventArgs) Handles btnSelectApplet.Click
        If sc.SelectApplet(1, 0) Then
            btnSelectApplet.BackColor = SharedFunction.SuccessColor
            WriteToRTB("select applet success")
        Else
            btnSelectApplet.BackColor = SharedFunction.ErrorColor
            WriteToRTB("select applet failed")
        End If
    End Sub

    Private Sub btnAuthentication1_Click(sender As Object, e As EventArgs) Handles btnAuthentication1.Click
        If sc.AuthenticateSL1 Then
            WriteToRTB("SL1 authentication success")
            btnAuthentication1.BackColor = SharedFunction.SuccessColor
        Else
            btnAuthentication1.BackColor = SharedFunction.ErrorColor
            WriteToRTB("SL1 authentication failed")
        End If
    End Sub

    Private Shared Function Util() As UMIDLibrary.AllCardTech_Util
        Return New UMIDLibrary.AllCardTech_Util()
    End Function

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ReadCard()
    End Sub

    Private Sub btnAuthentication2_Click(sender As Object, e As EventArgs) Handles btnAuthentication2.Click
        If sc.AuthenticateSL2(Util.AsciiToByteArray(CardPIN)) Then
            btnAuthentication2.BackColor = SharedFunction.SuccessColor
            WriteToRTB("SL2 authentication success")
        Else
            btnAuthentication2.BackColor = SharedFunction.ErrorColor
            WriteToRTB("SL2 authentication failed")
        End If
    End Sub

    Private Sub WriteToRTB(ByVal data As String)
        rtb.AppendText(SharedFunction.TimeStamp & data & vbNewLine)
        rtb.ScrollToCaret()
        Application.DoEvents()
    End Sub

    Private Sub grid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentDoubleClick
        If grid.Rows(e.RowIndex).Cells("ElementValue").Value.Contains("locate") Then Process.Start("explorer.exe", "TempBio")
    End Sub

    Private Sub ChangeGridForeColor()
        For Each gridRow As DataGridViewRow In grid.Rows
            If gridRow.Cells("ElementValue").Value.ToString.Contains("failed") Then
                gridRow.Cells("ElementValue").Style.ForeColor = SharedFunction.ErrorColor
            Else
                gridRow.Cells("ElementValue").Style.ForeColor = DefaultForeColor
            End If
        Next
    End Sub

    Private Sub btnRewrite_Click(sender As Object, e As EventArgs) Handles btnRewrite.Click
        Dim bln As Boolean
        bln = sc.RewriteFingerprintLeftPrimary(txtUserID.Text, txtMachineName.Text, System.IO.File.ReadAllBytes(Live_Lprimary))
        If bln Then bln = sc.RewriteFingerprintLeftSecondary(txtUserID.Text, txtMachineName.Text, System.IO.File.ReadAllBytes(Live_Rprimary))
        If bln Then bln = sc.RewriteFingerprintRightPrimary(txtUserID.Text, txtMachineName.Text, System.IO.File.ReadAllBytes(Live_Lbackup))
        If bln Then bln = sc.RewriteFingerprintRightSecondary(txtUserID.Text, txtMachineName.Text, System.IO.File.ReadAllBytes(Live_Rbackup))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnResetFingerprints.Text = "CANCEL"

        CaptureFingerprint(SagemCapturingDLL.Sagem.SagemFingerID.LeftIndex)
        txtLPStatus.Clear()
        CaptureFingerprint(SagemCapturingDLL.Sagem.SagemFingerID.LeftThumb)
        txtLBStatus.Clear()
        CaptureFingerprint(SagemCapturingDLL.Sagem.SagemFingerID.RightIndex)
        txtRPStatus.Clear()
        CaptureFingerprint(SagemCapturingDLL.Sagem.SagemFingerID.RightThumb)
        txtRBStatus.Clear()

        btnResetFingerprints.Text = "RESET"
    End Sub

    Private Sub CaptureFingerprint(ByVal SagemFingerID As SagemCapturingDLL.Sagem.SagemFingerID)
        Select Case SagemFingerID
            Case SagemCapturingDLL.Sagem.SagemFingerID.LeftIndex
                If _sagem Is Nothing Then _sagem = New SagemCapturingDLL.Sagem(pbLP, txtLPQuality, txtLPStatus)
                If _sagem.Success Then
                    txtFingerStatus.Text = "PLACE LEFT INDEX FINGER ON FINGER SCANNER"
                    If _sagem.Acquire(SagemFingerID, Live_Lprimary.Replace(".ansi-fmr", ".jpg"), Live_Lprimary, "", CInt(txtQualityThreshold.Text)) Then
                        If Not _sagem.ImageResult Is Nothing Then pbLP.Image = _sagem.ImageResult
                    End If
                    End If
            Case SagemCapturingDLL.Sagem.SagemFingerID.LeftThumb
                If _sagem Is Nothing Then _sagem = New SagemCapturingDLL.Sagem(pbLB, txtLBQuality, txtLBStatus)
                If _sagem.Success Then
                    txtFingerStatus.Text = "PLACE LEFT THUMB FINGER ON FINGER SCANNER"
                    If _sagem.Acquire(SagemFingerID, Live_Lbackup.Replace(".ansi-fmr", ".jpg"), Live_Lbackup, "", CInt(txtQualityThreshold.Text)) Then
                        If Not _sagem.ImageResult Is Nothing Then pbLB.Image = _sagem.ImageResult
                    End If
                End If
            Case SagemCapturingDLL.Sagem.SagemFingerID.RightIndex
                If _sagem Is Nothing Then _sagem = New SagemCapturingDLL.Sagem(pbRP, txtRPQuality, txtRPStatus)
                If _sagem.Success Then
                    txtFingerStatus.Text = "PLACE RIGHT INDEX FINGER ON FINGER SCANNER"
                    If _sagem.Acquire(SagemFingerID, Live_Rprimary.Replace(".ansi-fmr", ".jpg"), Live_Rprimary, "", CInt(txtQualityThreshold.Text)) Then
                        If Not _sagem.ImageResult Is Nothing Then pbLP.Image = _sagem.ImageResult
                    End If
                End If
            Case SagemCapturingDLL.Sagem.SagemFingerID.RightThumb
                If _sagem Is Nothing Then _sagem = New SagemCapturingDLL.Sagem(pbRB, txtRBQuality, txtRBStatus)
                If _sagem.Success Then
                    txtFingerStatus.Text = "PLACE RIGHT THUMB FINGER ON FINGER SCANNER"
                    If _sagem.Acquire(SagemFingerID, Live_Rbackup.Replace(".ansi-fmr", ".jpg"), Live_Rbackup, "", CInt(txtQualityThreshold.Text)) Then
                        If Not _sagem.ImageResult Is Nothing Then pbLB.Image = _sagem.ImageResult
                    End If
                End If
        End Select
        If Not _sagem Is Nothing Then _sagem = Nothing
    End Sub

    Private Sub Main2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _sagem = Nothing
    End Sub

    Private Sub btnResetFingerprints_Click(sender As Object, e As EventArgs) Handles btnResetFingerprints.Click
        If btnResetFingerprints.Text = "RESET" Then
            pbLP.Image = Nothing
            pbLB.Image = Nothing
            pbRP.Image = Nothing
            pbRB.Image = Nothing
            txtLPStatus.Clear()
            txtLBStatus.Clear()
            txtRPStatus.Clear()
            txtRBStatus.Clear()
            txtLPQuality.Clear()
            txtLBQuality.Clear()
            txtRPQuality.Clear()
            txtRBQuality.Clear()
        Else
            If Not _sagem Is Nothing Then
                _sagem.CancelAcquisition()
                _sagem = Nothing
            End If
        End If

    End Sub

End Class