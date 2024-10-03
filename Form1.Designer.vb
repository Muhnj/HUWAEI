<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblItem = New Label()
        lblQty = New Label()
        lblPrice = New Label()
        lblAmount = New Label()
        txtItem1 = New TextBox()
        txtItem2 = New TextBox()
        txtItem3 = New TextBox()
        txtItem4 = New TextBox()
        txtQty4 = New TextBox()
        txtQty3 = New TextBox()
        txtQty2 = New TextBox()
        txtQty1 = New TextBox()
        txtPrice2 = New TextBox()
        txtPrice1 = New TextBox()
        txtPrice4 = New TextBox()
        txtPrice3 = New TextBox()
        txtAmount1 = New TextBox()
        txtAmount2 = New TextBox()
        txtAmount3 = New TextBox()
        txtAmount4 = New TextBox()
        btnAmount = New Button()
        btnSubTotal = New Button()
        txtSubTotal = New TextBox()
        txtVat = New TextBox()
        btnVat = New Button()
        cboPaymentMethod = New ComboBox()
        lblPaymentMethod = New Label()
        lblServedBy = New Label()
        txtServedBy = New TextBox()
        lblChinaTownStoreReceipt = New Label()
        Label1 = New Label()
        lblReceiptNo = New Label()
        txtReceiptno = New TextBox()
        lblDate = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        btnPrint = New Button()
        btnAddItems = New Button()
        txtItem = New TextBox()
        txtPrice = New TextBox()
        txtTotal = New TextBox()
        btnCalculate = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        btnTamount = New Button()
        txtTamount = New TextBox()
        lblClientDetails = New Label()
        txtClient = New TextBox()
        btnDiscount = New Button()
        txtDiscount = New TextBox()
        txtReceipt = New TextBox()
        lblItemAmount = New Label()
        lblItemAdded = New Label()
        txtTransactionId = New Label()
        txtTransId = New TextBox()
        SuspendLayout()
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Font = New Font("Cooper Black", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblItem.ForeColor = Color.Blue
        lblItem.Location = New Point(152, 177)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(39, 14)
        lblItem.TabIndex = 0
        lblItem.Text = "ITEM"
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQty.ForeColor = Color.Blue
        lblQty.Location = New Point(272, 178)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(33, 14)
        lblQty.TabIndex = 1
        lblQty.Text = "QTY"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.Blue
        lblPrice.Location = New Point(381, 180)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(46, 14)
        lblPrice.TabIndex = 2
        lblPrice.Text = "PRICE"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmount.ForeColor = Color.Blue
        lblAmount.Location = New Point(552, 177)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(65, 14)
        lblAmount.TabIndex = 3
        lblAmount.Text = "AMOUNT"
        ' 
        ' txtItem1
        ' 
        txtItem1.Location = New Point(126, 199)
        txtItem1.Name = "txtItem1"
        txtItem1.Size = New Size(114, 21)
        txtItem1.TabIndex = 4
        ' 
        ' txtItem2
        ' 
        txtItem2.Location = New Point(127, 225)
        txtItem2.Name = "txtItem2"
        txtItem2.Size = New Size(114, 21)
        txtItem2.TabIndex = 5
        ' 
        ' txtItem3
        ' 
        txtItem3.Location = New Point(126, 252)
        txtItem3.Name = "txtItem3"
        txtItem3.Size = New Size(114, 21)
        txtItem3.TabIndex = 6
        ' 
        ' txtItem4
        ' 
        txtItem4.Location = New Point(126, 282)
        txtItem4.Name = "txtItem4"
        txtItem4.Size = New Size(114, 21)
        txtItem4.TabIndex = 7
        ' 
        ' txtQty4
        ' 
        txtQty4.Location = New Point(247, 282)
        txtQty4.Name = "txtQty4"
        txtQty4.Size = New Size(114, 21)
        txtQty4.TabIndex = 8
        ' 
        ' txtQty3
        ' 
        txtQty3.Location = New Point(246, 252)
        txtQty3.Name = "txtQty3"
        txtQty3.Size = New Size(114, 21)
        txtQty3.TabIndex = 9
        ' 
        ' txtQty2
        ' 
        txtQty2.Location = New Point(246, 225)
        txtQty2.Name = "txtQty2"
        txtQty2.Size = New Size(114, 21)
        txtQty2.TabIndex = 10
        ' 
        ' txtQty1
        ' 
        txtQty1.Location = New Point(246, 199)
        txtQty1.Name = "txtQty1"
        txtQty1.Size = New Size(114, 21)
        txtQty1.TabIndex = 11
        ' 
        ' txtPrice2
        ' 
        txtPrice2.Location = New Point(367, 225)
        txtPrice2.Name = "txtPrice2"
        txtPrice2.Size = New Size(114, 21)
        txtPrice2.TabIndex = 12
        ' 
        ' txtPrice1
        ' 
        txtPrice1.Location = New Point(366, 199)
        txtPrice1.Name = "txtPrice1"
        txtPrice1.Size = New Size(114, 21)
        txtPrice1.TabIndex = 13
        ' 
        ' txtPrice4
        ' 
        txtPrice4.Location = New Point(367, 282)
        txtPrice4.Name = "txtPrice4"
        txtPrice4.Size = New Size(114, 21)
        txtPrice4.TabIndex = 14
        ' 
        ' txtPrice3
        ' 
        txtPrice3.Location = New Point(366, 252)
        txtPrice3.Name = "txtPrice3"
        txtPrice3.Size = New Size(114, 21)
        txtPrice3.TabIndex = 15
        ' 
        ' txtAmount1
        ' 
        txtAmount1.Location = New Point(486, 199)
        txtAmount1.Name = "txtAmount1"
        txtAmount1.Size = New Size(228, 21)
        txtAmount1.TabIndex = 16
        ' 
        ' txtAmount2
        ' 
        txtAmount2.Location = New Point(486, 225)
        txtAmount2.Name = "txtAmount2"
        txtAmount2.Size = New Size(228, 21)
        txtAmount2.TabIndex = 17
        ' 
        ' txtAmount3
        ' 
        txtAmount3.Location = New Point(489, 252)
        txtAmount3.Name = "txtAmount3"
        txtAmount3.Size = New Size(228, 21)
        txtAmount3.TabIndex = 18
        ' 
        ' txtAmount4
        ' 
        txtAmount4.Location = New Point(487, 282)
        txtAmount4.Name = "txtAmount4"
        txtAmount4.Size = New Size(228, 21)
        txtAmount4.TabIndex = 19
        ' 
        ' btnAmount
        ' 
        btnAmount.Location = New Point(366, 312)
        btnAmount.Name = "btnAmount"
        btnAmount.Size = New Size(113, 29)
        btnAmount.TabIndex = 20
        btnAmount.Text = "Amount"
        btnAmount.UseVisualStyleBackColor = True
        ' 
        ' btnSubTotal
        ' 
        btnSubTotal.Location = New Point(366, 347)
        btnSubTotal.Name = "btnSubTotal"
        btnSubTotal.Size = New Size(113, 27)
        btnSubTotal.TabIndex = 21
        btnSubTotal.Text = "SUBTOTAL"
        btnSubTotal.UseVisualStyleBackColor = True
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(489, 349)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(228, 21)
        txtSubTotal.TabIndex = 22
        ' 
        ' txtVat
        ' 
        txtVat.Location = New Point(489, 379)
        txtVat.Name = "txtVat"
        txtVat.Size = New Size(228, 21)
        txtVat.TabIndex = 23
        ' 
        ' btnVat
        ' 
        btnVat.Location = New Point(366, 380)
        btnVat.Name = "btnVat"
        btnVat.Size = New Size(113, 25)
        btnVat.TabIndex = 24
        btnVat.Text = "VAT"
        btnVat.UseVisualStyleBackColor = True
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentMethod.FormattingEnabled = True
        cboPaymentMethod.Items.AddRange(New Object() {"CASH", "BANK", "MOBILE MONEY"})
        cboPaymentMethod.Location = New Point(749, 479)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(228, 20)
        cboPaymentMethod.TabIndex = 25
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.ForeColor = Color.Blue
        lblPaymentMethod.Location = New Point(783, 459)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(130, 14)
        lblPaymentMethod.TabIndex = 26
        lblPaymentMethod.Text = "PAYMENT METHOD"
        ' 
        ' lblServedBy
        ' 
        lblServedBy.AutoSize = True
        lblServedBy.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblServedBy.ForeColor = Color.Blue
        lblServedBy.Location = New Point(812, 506)
        lblServedBy.Name = "lblServedBy"
        lblServedBy.Size = New Size(81, 14)
        lblServedBy.TabIndex = 27
        lblServedBy.Text = "SERVED BY"
        ' 
        ' txtServedBy
        ' 
        txtServedBy.Location = New Point(749, 525)
        txtServedBy.Name = "txtServedBy"
        txtServedBy.Size = New Size(228, 21)
        txtServedBy.TabIndex = 28
        ' 
        ' lblChinaTownStoreReceipt
        ' 
        lblChinaTownStoreReceipt.AutoSize = True
        lblChinaTownStoreReceipt.Font = New Font("Elephant", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChinaTownStoreReceipt.ForeColor = Color.Blue
        lblChinaTownStoreReceipt.Location = New Point(12, 2)
        lblChinaTownStoreReceipt.Name = "lblChinaTownStoreReceipt"
        lblChinaTownStoreReceipt.Size = New Size(486, 31)
        lblChinaTownStoreReceipt.TabIndex = 29
        lblChinaTownStoreReceipt.Text = " CHINA TOWN STORE RECEIPT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(53, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 16)
        Label1.TabIndex = 30
        Label1.Text = "Quality is our first priority"
        ' 
        ' lblReceiptNo
        ' 
        lblReceiptNo.AutoSize = True
        lblReceiptNo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReceiptNo.ForeColor = Color.Blue
        lblReceiptNo.Location = New Point(676, 40)
        lblReceiptNo.Name = "lblReceiptNo"
        lblReceiptNo.Size = New Size(74, 14)
        lblReceiptNo.TabIndex = 31
        lblReceiptNo.Text = "Receipt no:"
        ' 
        ' txtReceiptno
        ' 
        txtReceiptno.Location = New Point(756, 35)
        txtReceiptno.Name = "txtReceiptno"
        txtReceiptno.Size = New Size(221, 21)
        txtReceiptno.TabIndex = 32
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Blue
        lblDate.Location = New Point(677, 63)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(40, 14)
        lblDate.TabIndex = 33
        lblDate.Text = "Date:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(735, 58)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(242, 21)
        DateTimePicker1.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(91, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 48)
        Label2.TabIndex = 36
        Label2.Text = "Located in Ntida plot 25556" & vbCrLf & "Tel: 07710003556,0751000355" & vbCrLf & "munirumujuzi@gmail.com"
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(34, 506)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 37
        btnPrint.Text = "PRINT"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnAddItems
        ' 
        btnAddItems.Location = New Point(796, 275)
        btnAddItems.Name = "btnAddItems"
        btnAddItems.Size = New Size(94, 29)
        btnAddItems.TabIndex = 38
        btnAddItems.Text = "ADD ITEM"
        btnAddItems.UseVisualStyleBackColor = True
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(861, 210)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(125, 21)
        txtItem.TabIndex = 39
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(861, 250)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 21)
        txtPrice.TabIndex = 40
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(861, 323)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 21)
        txtTotal.TabIndex = 41
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(761, 320)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 43
        btnCalculate.Text = "CALCULATE"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' btnTamount
        ' 
        btnTamount.Location = New Point(366, 451)
        btnTamount.Name = "btnTamount"
        btnTamount.Size = New Size(111, 25)
        btnTamount.TabIndex = 44
        btnTamount.Text = "TAMOUNT"
        btnTamount.UseVisualStyleBackColor = True
        ' 
        ' txtTamount
        ' 
        txtTamount.Location = New Point(489, 451)
        txtTamount.Name = "txtTamount"
        txtTamount.Size = New Size(228, 21)
        txtTamount.TabIndex = 45
        ' 
        ' lblClientDetails
        ' 
        lblClientDetails.AutoSize = True
        lblClientDetails.Font = New Font("Algerian", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblClientDetails.ForeColor = Color.Blue
        lblClientDetails.Location = New Point(101, 143)
        lblClientDetails.Name = "lblClientDetails"
        lblClientDetails.Size = New Size(119, 16)
        lblClientDetails.TabIndex = 46
        lblClientDetails.Text = "CLIENT DETAILS"
        ' 
        ' txtClient
        ' 
        txtClient.Location = New Point(289, 140)
        txtClient.Name = "txtClient"
        txtClient.Size = New Size(212, 21)
        txtClient.TabIndex = 47
        ' 
        ' btnDiscount
        ' 
        btnDiscount.Location = New Point(366, 411)
        btnDiscount.Name = "btnDiscount"
        btnDiscount.Size = New Size(113, 25)
        btnDiscount.TabIndex = 48
        btnDiscount.Text = "Discount"
        btnDiscount.UseVisualStyleBackColor = True
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(489, 412)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(228, 21)
        txtDiscount.TabIndex = 49
        ' 
        ' txtReceipt
        ' 
        txtReceipt.Location = New Point(745, 188)
        txtReceipt.Name = "txtReceipt"
        txtReceipt.Size = New Size(241, 21)
        txtReceipt.TabIndex = 50
        ' 
        ' lblItemAmount
        ' 
        lblItemAmount.AutoSize = True
        lblItemAmount.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblItemAmount.ForeColor = Color.Blue
        lblItemAmount.Location = New Point(735, 252)
        lblItemAmount.Name = "lblItemAmount"
        lblItemAmount.Size = New Size(100, 14)
        lblItemAmount.TabIndex = 51
        lblItemAmount.Text = "ITEM AMOUNT"
        ' 
        ' lblItemAdded
        ' 
        lblItemAdded.AutoSize = True
        lblItemAdded.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblItemAdded.ForeColor = Color.Blue
        lblItemAdded.Location = New Point(735, 212)
        lblItemAdded.Name = "lblItemAdded"
        lblItemAdded.Size = New Size(90, 14)
        lblItemAdded.TabIndex = 52
        lblItemAdded.Text = "ITEM ADDED"
        ' 
        ' txtTransactionId
        ' 
        txtTransactionId.AutoSize = True
        txtTransactionId.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTransactionId.ForeColor = Color.Blue
        txtTransactionId.Location = New Point(676, 15)
        txtTransactionId.Name = "txtTransactionId"
        txtTransactionId.Size = New Size(98, 14)
        txtTransactionId.TabIndex = 54
        txtTransactionId.Text = "Transaction ID"
        ' 
        ' txtTransId
        ' 
        txtTransId.Location = New Point(774, 13)
        txtTransId.Name = "txtTransId"
        txtTransId.Size = New Size(202, 21)
        txtTransId.TabIndex = 55
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 12F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1028, 545)
        Controls.Add(txtTransId)
        Controls.Add(txtTransactionId)
        Controls.Add(lblItemAdded)
        Controls.Add(lblItemAmount)
        Controls.Add(txtReceipt)
        Controls.Add(txtDiscount)
        Controls.Add(btnDiscount)
        Controls.Add(txtClient)
        Controls.Add(lblClientDetails)
        Controls.Add(txtTamount)
        Controls.Add(btnTamount)
        Controls.Add(btnCalculate)
        Controls.Add(txtTotal)
        Controls.Add(txtPrice)
        Controls.Add(txtItem)
        Controls.Add(btnAddItems)
        Controls.Add(btnPrint)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblDate)
        Controls.Add(txtReceiptno)
        Controls.Add(lblReceiptNo)
        Controls.Add(Label1)
        Controls.Add(lblChinaTownStoreReceipt)
        Controls.Add(txtServedBy)
        Controls.Add(lblServedBy)
        Controls.Add(lblPaymentMethod)
        Controls.Add(cboPaymentMethod)
        Controls.Add(btnVat)
        Controls.Add(txtVat)
        Controls.Add(txtSubTotal)
        Controls.Add(btnSubTotal)
        Controls.Add(btnAmount)
        Controls.Add(txtAmount4)
        Controls.Add(txtAmount3)
        Controls.Add(txtAmount2)
        Controls.Add(txtAmount1)
        Controls.Add(txtPrice3)
        Controls.Add(txtPrice4)
        Controls.Add(txtPrice1)
        Controls.Add(txtPrice2)
        Controls.Add(txtQty1)
        Controls.Add(txtQty2)
        Controls.Add(txtQty3)
        Controls.Add(txtQty4)
        Controls.Add(txtItem4)
        Controls.Add(txtItem3)
        Controls.Add(txtItem2)
        Controls.Add(txtItem1)
        Controls.Add(lblAmount)
        Controls.Add(lblPrice)
        Controls.Add(lblQty)
        Controls.Add(lblItem)
        Font = New Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblItem As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtItem1 As TextBox
    Friend WithEvents txtItem2 As TextBox
    Friend WithEvents txtItem3 As TextBox
    Friend WithEvents txtItem4 As TextBox
    Friend WithEvents txtQty4 As TextBox
    Friend WithEvents txtQty3 As TextBox
    Friend WithEvents txtQty2 As TextBox
    Friend WithEvents txtQty1 As TextBox
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents txtPrice4 As TextBox
    Friend WithEvents txtPrice3 As TextBox
    Friend WithEvents txtAmount1 As TextBox
    Friend WithEvents txtAmount2 As TextBox
    Friend WithEvents txtAmount3 As TextBox
    Friend WithEvents txtAmount4 As TextBox
    Friend WithEvents btnAmount As Button
    Friend WithEvents btnSubTotal As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents btnVat As Button
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblServedBy As Label
    Friend WithEvents txtServedBy As TextBox
    Friend WithEvents lblChinaTownStoreReceipt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReceiptNo As Label
    Friend WithEvents txtReceiptno As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnAddItems As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnTamount As Button
    Friend WithEvents txtTamount As TextBox
    Friend WithEvents lblClientDetails As Label
    Friend WithEvents txtClient As TextBox
    Friend WithEvents btnDiscount As Button
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents lblItemAdded As Label
    Friend WithEvents txtTransactionId As Label
    Friend WithEvents txtTransId As TextBox

End Class
