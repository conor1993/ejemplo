' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:34
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.BackwardsCompatibility.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
#If Not CF Then
Imports System.Runtime.Serialization
#End If
Imports System.Collections
Imports Integralab.ORM.FactoryClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' Helper class which will eases the creation of custom made resultsets. Usable in typed lists
	''' and dynamic lists created using the dynamic query engine.
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ResultsetFields 
#Else
	<Serializable()> _
	Public Class ResultsetFields 
#End If
		Inherits EntityFields
		Implements ISerializable
	
		''' <summary>CTor</summary>
		Public Sub New(amountFields As Integer)
			MyBase.New(amountFields, InheritanceInfoProviderSingleton.GetInstance(), Nothing)
		End Sub
				
		''' <summary>Deserialization constructor</summary>
		''' <param name="info">Info.</param>
		''' <param name="context">Context.</param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext )
			MyBase.New(CInt(info.GetInt32("_amountFields")), InheritanceInfoProviderSingleton.GetInstance(), Nothing)
			Dim fields As ArrayList = CType(info.GetValue("_fields", GetType(ArrayList)), ArrayList)
			For i As Integer = 0 To fields.Count-1
				Me(i) = CType(fields(i), IEntityField)
			Next i
		End Sub

		''' <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"/> With the data needed To serialize the target Object.</summary>
		''' <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> To populate With data.</param>
		''' <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"/>) For this serialization.</param>
		Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext ) Implements ISerializable.GetObjectData
			info.AddValue("_amountFields", Me.Count)
			Dim fields As New ArrayList(Me.Count)
			For i As Integer = 0 To Me.Count-1
				fields.Add(Me(i))
			Next i
			info.AddValue("_fields", fields, GetType(ArrayList))
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AcumuladoCuentasContablesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AcumuladoCuentasContablesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AcumuladoCuentasContablesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenCatalogoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenCatalogoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenCatalogoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesFamiliasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesFamiliasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesFamiliasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenesSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AlmacenSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AplicMediDetDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AutCreditoEmbFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AutCreditoEmbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AutCreditoEmbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As AutorizaProcesosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As AutorizaProcesosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As AutorizaProcesosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As BancosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As BancosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As BancosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As BeneficiarioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As BeneficiarioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As BeneficiarioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraFolioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraFolioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraFolioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraPvFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As BitacoraPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabAplForFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabAplForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabAplForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediReimFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediReimFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediReimFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediTrabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediTrabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMediTrabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabProMedFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabProMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabProMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRegComFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRegComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CabRegComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatAgrupadoresBalGralEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatAgrupadoresBalGralEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatAgrupadoresBalGralEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatDeptosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatDeptosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatDeptosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatIntroductoresFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatIntroductoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatIntroductoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugaresDeCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugaresDeCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugaresDeCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugComFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatLugComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatNutrientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatNutrientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatNutrientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexCortFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexCortFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexCortFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexProdFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexProdFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatPrexProdFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CatTipNotasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CatTipNotasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CatTipNotasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CfgCtrlCtasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CfgCtrlCtasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CfgCtrlCtasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeDevueltoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeDevueltoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequeDevueltoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequesPosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequesPosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ChequesPosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreFicticioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreFicticioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreFicticioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreLoteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreLoteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CierreLoteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CiudadFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CiudadFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CiudadFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ClasificadorDeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ClasificadorDeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ClasificadorDeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ClienteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ClienteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ClienteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoCuentaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoCuentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConceptoFlujoCuentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConCfgCtasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConCfgCtasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConCfgCtasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CondicionesPagoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CondicionesPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CondicionesPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigGanFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigPuntoVtaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigPuntoVtaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfigPuntoVtaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionChequesImpFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionChequesImpFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionChequesImpFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionLecturaEtiquetaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionLecturaEtiquetaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConfiguracionLecturaEtiquetaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConLotSacFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConLotSacFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConLotSacFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ConMesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ConMesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ConMesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposOperacionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposOperacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposOperacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposTercerosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposTercerosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ContDiotTiposTercerosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ControlTurnoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ControlTurnoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ControlTurnoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CostoProductoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CotizacionServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaContableFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaContableFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentaContableFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentasFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentasFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As CuentasFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAlimentosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAlimentosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAlimentosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleClasificadordeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleClasificadordeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleClasificadordeEstadosFinancierosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleKitPvFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleKitPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetalleKitPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAplForFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAplForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetAplForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetBalanceFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetDproMedFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetDproMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetDproMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetEdoResFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetGasTransFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetMovGanFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormLoteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormLoteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetPrepFormLoteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetProMedFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetProMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetProMedFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRecCorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRegComFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRegComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DetRegComFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DevolucionProductosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DevolucionProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DevolucionProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoImagenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoImagenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoImagenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTextoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTextoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTextoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoCampoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoCampoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DocumentoTipoCampoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As DomicilioFiscalesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ECtSatcatBancosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ECtSatcatBancosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ECtSatcatBancosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As EstadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As EstadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As EstadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturaFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturaFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturaFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetProductosTotalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetProductosTotalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FacturasClientesDetProductosTotalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FolioFacturaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As FormaPagoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As FormaPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As FormaPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As GastosDepartamentosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As GastosDepartamentosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As GastosDepartamentosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As HistorialCambiosFechaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As HistorialCambiosFechaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As HistorialCambiosFechaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As IngresoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As IngresoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As IngresoCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As inventarioAlmacenLotesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As inventarioAlmacenLotesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As inventarioAlmacenLotesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenDetallesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenDetallesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InventarioMovimientoAlmacenDetallesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As InvHistorialPvFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As InvHistorialPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As InvHistorialPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As LineaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As LineaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As LineaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ListadePreciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ListadePreciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ListadePreciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaPrecioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MarcaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MarcaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MarcaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McatCentroCostosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McatCentroCostosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McatCentroCostosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McattiposclienteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McattiposclienteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McattiposclienteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatCorralesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabForFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesCabForFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatLotesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatTiposCorralFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatTiposCorralFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McecatTiposCorralFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCausasMuerteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCausasMuerteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCausasMuerteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatChoferesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatChoferesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatChoferesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCompradoresdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCompradoresdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatCompradoresdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatConcepGastosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatConcepGastosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatConcepGastosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatMovGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatMovGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatMovGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatTiposdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatTiposdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatTiposdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatVehiculosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatVehiculosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcatVehiculosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgcompraGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McgconfiguracionMovimientoGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McgconfiguracionMovimientoGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McgconfiguracionMovimientoGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McomCotizacionCompraProveedorDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As McomRecepcionOrdenCompraDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As McomRecepcionOrdenCompraDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As McomRecepcionOrdenCompraDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoPagoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MetodoPagoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacCatClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacCatClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacCatClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacClientesDatosFiscalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacClientesDatosFiscalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacClientesDatosFiscalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MfacEmbarquesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadorAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadorAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadorAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadoresFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliadoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MgcnfFoliosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MgralcatPuntosEntregaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MgralcatPuntosEntregaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MgralcatPuntosEntregaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvdetallesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvdetallesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvMovimientosAlmacenPvdetallesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenEntradaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenProdDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MinvTransferenciaAlmacenSalidaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ModuloFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ModuloFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ModuloFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MonedaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MonedaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MonedaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoBajaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MotivoCancelacionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMotivoDevolucionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMotivoDevolucionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMotivoDevolucionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatProductosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatServiciosRastroFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatServiciosRastroFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatServiciosRastroFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatTiposAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatTiposAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccatTiposAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccomprasCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccomprasCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccomprasCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscconfigMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscconfigMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscconfigMovtosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccortesPreCortesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccortesPreCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MsccortesPreCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalAcorteFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalAcorteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalAcorteFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalComprasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalComprasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscdetCanalComprasFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioProductoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscinventarioProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetComparacionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetComparacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscloteCortesDetComparacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscmovtosAlmacenDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosValorAgregadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosValorAgregadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscproductosValorAgregadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrecepcionCanalesDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscregistroSacrificioCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscregistroSacrificioCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscregistroSacrificioCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionCortesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionCortesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionCortesClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionProductosRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionProductosRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscrelacionProductosRastrosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MscsalidasGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MveCtaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MveCtaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MveCtaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As MvtosBancariosCbFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As MvtosBancariosCbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As MvtosBancariosCbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatEmpleadosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatEmpleadosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatEmpleadosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatPuestosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatPuestosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomCatPuestosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomDiasVacacionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomDiasVacacionesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomDiasVacacionesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImportesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImportesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImportesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImssinfonavitFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImssinfonavitFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomImssinfonavitFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomIsrFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomIsrFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomIsrFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NomSubsidioEmpleoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NomSubsidioEmpleoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NomSubsidioEmpleoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaCreditoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleRespFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleRespFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaDetalleRespFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaRespFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaRespFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As NotaVentaRespFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As OrdenServicioDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoCheDevueltoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoDeCtesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoDeCtesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PagoDeCtesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PeriodosContFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PeriodosContFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PeriodosContFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PlazaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PlazaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PlazaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PoblacionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PoblacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PoblacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PogrCbFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PogrCbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PogrCbFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PoGrDtFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PoGrDtFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PoGrDtFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PolizasModeloDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PresentacionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PresentacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PresentacionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PresupuestoCompraDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoCostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoCostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoCostoIndirectoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoMezclaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoMezclaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProductoMezclaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProrraRecFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProrraRecFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProrraRecFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorAvanzadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorAvanzadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ProveedorAvanzadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As PvnotasVentaRetDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RecepcionOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ReferenciaProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ReferenciaProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ReferenciaProductoDerivadoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RegistroSacrificiosDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RetiroCajaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RetiroCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RetiroCajaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As RFCFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As RFCFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As RFCFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SalidaGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SatAgrupadorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SatAgrupadorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SatAgrupadorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosPorSacrificioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosPorSacrificioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosPorSacrificioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosXembarqueFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosXembarqueFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ServiciosXembarqueFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudProductoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SolicitudServiciosDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SubLineaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SubLineaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SubLineaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As SucursalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As SucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As SucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoCambioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoCambioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoCambioFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoComicionistaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMonedaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMonedaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMonedaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMotivoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMotivoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMotivoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoMovimientoAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoPresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoPresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoPresupuestoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProductoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoVentaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoVentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As TipoVentaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UnidadMedidaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UnidadMedidaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UnidadMedidaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrBanDepositosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrBanDepositosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrBanDepositosFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrConfigContabilidadFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrConfigContabilidadFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrConfigContabilidadFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasApagarFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasApagarFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasApagarFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasCabFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetRecepcionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetRecepcionesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxpfacturasDetRecepcionesFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxppagosProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxppagosProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrCxppagosProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdConfiguracionFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRecepcionGanadoDetFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRegistroSacrificiosDecomisoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRegistroSacrificiosDecomisoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsrProdRegistroSacrificiosDecomisoFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuariosSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuariosSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuariosSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuarioSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuarioSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As UsuarioSucursalFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, entityAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The alias to use for this field in the resultset</param>
		''' <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ZonaDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, entityAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, entityAlias, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As ComCotizacionesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ComCotizacionesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ComCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ComCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaParaAnalizarCotizacionCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaParaAnalizarCotizacionCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaParaAnalizarCotizacionCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As ListaParaAnalizarCotizacionCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexDetalleFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexDetalleFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionDetFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionDetFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmKardexProduccionDetFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmTarjetasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmTarjetasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmTarjetasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwAlmTarjetasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusqCanalesEmbarqueFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusqCanalesEmbarqueFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusqCanalesEmbarqueFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusqCanalesEmbarqueFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionFormulaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionFormulaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionFormulaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionFormulaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionMedicamentoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionMedicamentoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionMedicamentoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaAplicacionMedicamentoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaClientesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaClientesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComparacionMedicamentosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComparacionMedicamentosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComparacionMedicamentosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComparacionMedicamentosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasdeGanadoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasdeGanadoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasdeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasGanadoDetalleFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasGanadoDetalleFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasGanadoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaComprasGanadoDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCortesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCortesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCortesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCotizacionesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCotizacionesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaDevolucionesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaDevolucionesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaDevolucionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaDevolucionesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaEmbarquesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaEmbarquesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaLoteCortesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaLoteCortesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaLoteCortesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaLoteCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaMovimientosAlmacenFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaMovimientosAlmacenFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaMovimientosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaMovimientosAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaPreparacionMezclaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaPreparacionMezclaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaPreparacionMezclaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaPreparacionMezclaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProductosCapturaInventarioFisicoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProductosCapturaInventarioFisicoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProductosCapturaInventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProductosCapturaInventarioFisicoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProrrateoMedicamentoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProrrateoMedicamentoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProrrateoMedicamentoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProrrateoMedicamentoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProveedorFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProveedorFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaProveedorFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaEntradaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaEntradaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaEntradaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaEntradaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaSalidaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaSalidaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaSalidaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwBusquedaTransferenciaSalidaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwClientesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwClientesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesPorTipodeGanadoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesPorTipodeGanadoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesPorTipodeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciaEnCorralesPorTipodeGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciasLotesCorralesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciasLotesCorralesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciasLotesCorralesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwComGanExistenciasLotesCorralesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqCotizacionServiciosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqCotizacionServiciosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqCotizacionServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqCotizacionServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqSolicitudServiciosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqSolicitudServiciosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqSolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompBusqSolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompConsultaOrdenCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompConsultaOrdenCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompConsultaOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompConsultaOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompCotizacionServiciosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompCotizacionServiciosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompCotizacionServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompCotizacionServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompFiniquitoOrdenCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompFiniquitoOrdenCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompFiniquitoOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompFiniquitoOrdenCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompOrdenesdeCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompOrdenesdeCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompOrdenesdeCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompOrdenesdeCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompRecepciondeOrdenesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompRecepciondeOrdenesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompRecepciondeOrdenesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompRecepciondeOrdenesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteCotizacionesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteCotizacionesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteCotizacionesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesServiciosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesServiciosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteOrdenesServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReportePresupuestosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReportePresupuestosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReportePresupuestosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReportePresupuestosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteRecepcionesOrdenesCompraFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteRecepcionesOrdenesCompraFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteRecepcionesOrdenesCompraFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompReporteRecepcionesOrdenesCompraFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompsolicitudesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompsolicitudesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompsolicitudesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompsolicitudesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompSolicitudServiciosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompSolicitudServiciosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompSolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCompSolicitudServiciosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaCortesParaReimprecionFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaCortesParaReimprecionFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaCortesParaReimprecionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaCortesParaReimprecionFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasSinFiltradoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasSinFiltradoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasSinFiltradoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaFacturasSinFiltradoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaNominaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaNominaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaNominaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaNominaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaPakingListDetalleFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaPakingListDetalleFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaPakingListDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaPakingListDetalleFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaSacrificiosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaSacrificiosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaSacrificiosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwConsultaSacrificiosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwContCuentasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwContCuentasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwContCuentasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwContCuentasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCuentasFiscFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCuentasFiscFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCuentasFiscFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCuentasFiscFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcfacturasClientesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcfacturasClientesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcfacturasClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcfacturasClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcreporteCobranzaDiarioFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcreporteCobranzaDiarioFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcreporteCobranzaDiarioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxcreporteCobranzaDiarioFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpauxiliarPasivosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpauxiliarPasivosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpauxiliarPasivosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpauxiliarPasivosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasAgrupadasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasAgrupadasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasAgrupadasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasAgrupadasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasSinContabilizarFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasSinContabilizarFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasSinContabilizarFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwCxpfacturasSinContabilizarFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwFacturasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwFacturasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwFacturasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwHistorialdeComprasdeProductosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwHistorialdeComprasdeProductosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwHistorialdeComprasdeProductosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwHistorialdeComprasdeProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAlmacenDetFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAlmacenDetFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAlmacenDetFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAlmacenDetFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAmacenCabFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAmacenCabFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAmacenCabFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovAmacenCabFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovimientosAlmacenGeneralFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovimientosAlmacenGeneralFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovimientosAlmacenGeneralFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwMovimientosAlmacenGeneralFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwOrdenesServicioFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwOrdenesServicioFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwOrdenesServicioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwOrdenesServicioFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesCabeceroFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesCabeceroFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesCabeceroFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPagoClientesCabeceroFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwpagosaProveedoresFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwpagosaProveedoresFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwpagosaProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwpagosaProveedoresFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPolizasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPolizasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPolizasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwPolizasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesAgrupadosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesAgrupadosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesAgrupadosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdCortesAgrupadosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdDetalleCanalesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdDetalleCanalesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdDetalleCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdDetalleCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRegistroCanalesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRegistroCanalesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRegistroCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRegistroCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosCortesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosCortesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosCortesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosCortesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosSacrificiosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosSacrificiosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosSacrificiosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProdRendimientosSacrificiosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosEnAlmacenFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosEnAlmacenFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosEnAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosEnAlmacenFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGanadoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGanadoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGanadoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGeneralesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGeneralesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGeneralesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwProductosGeneralesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwRegistroSacrificioFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwRegistroSacrificioFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwRegistroSacrificioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwRegistroSacrificioFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteCanalesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteCanalesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteCanalesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteComprativoInventarioFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteComprativoInventarioFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteComprativoInventarioFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteComprativoInventarioFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDecomisosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDecomisosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDecomisosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReportedeEmabarquesDetalladoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReportedeEmabarquesDetalladoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReportedeEmabarquesDetalladoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReportedeEmabarquesDetalladoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesConcentradoFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesConcentradoFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesConcentradoFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDeEmbarquesConcentradoFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDevolucionesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDevolucionesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDevolucionesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteDevolucionesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteEmbarquesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteEmbarquesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteExistenciaSubProductosFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteExistenciaSubProductosFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteExistenciaSubProductosFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteExistenciaSubProductosFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteMovimientosProduccionFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteMovimientosProduccionFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteMovimientosProduccionFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteMovimientosProduccionFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteNominaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteNominaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteNominaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwReporteNominaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwTraspasoDeCajasFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwTraspasoDeCajasFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwTraspasoDeCajasFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwTraspasoDeCajasFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVentasXfacturaFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVentasXfacturaFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVentasXfacturaFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVentasXfacturaFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub
		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVtasEmbarquesFieldIndex, indexInResultset As Integer)
			DefineField(fieldToDefine, indexInResultset, String.Empty, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVtasEmbarquesFieldIndex, indexInResultset As Integer, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, aggregateFunctionToApply)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVtasEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String)
			DefineField(fieldToDefine, indexInResultset, fieldAlias, AggregateFunction.None)
		End Sub

		''' <summary>Creates the specified field on the position indexInResultset in the resultset. </summary>
		''' <param name="fieldToDefine">The specification of the field to create.</param>
		''' <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		''' <param name="fieldAlias">The fieldAlias to use for this field in the resultset</param>
		''' <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		Public Overloads Sub DefineField(fieldToDefine As VwVtasEmbarquesFieldIndex, indexInResultset As Integer, fieldAlias As String, aggregateFunctionToApply As AggregateFunction)
			MyBase.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, fieldAlias, aggregateFunctionToApply)
		End Sub

#Region "Included Code"

#End Region
	End Class
End Namespace
