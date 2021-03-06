using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V26.Datatype
{

///<summary>
/// <p>The HL7 OSP (Occurrence Span Code and Date) data type.  Consists of the following components: </p><ol>
/// <li>Occurrence Span Code (CNE)</li>
/// <li>Occurrence Span Start Date (DT)</li>
/// <li>Occurrence Span Stop Date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class OSP : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public OSP(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public OSP(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new CNE(message,"Occurrence Span Code");
		data[1] = new DT(message,"Occurrence Span Start Date");
		data[2] = new DT(message,"Occurrence Span Stop Date");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element OSP composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Occurrence Span Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CNE OccurrenceSpanCode {
get{
	   CNE ret = null;
	   try {
	      ret = (CNE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Occurrence Span Start Date (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStartDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Occurrence Span Stop Date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStopDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}