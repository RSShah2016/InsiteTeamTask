export class Attendance{
    MemberId:Number;
    Barcode: String;
    constructor(
        MemberId:Number,
        Barcode:String
    ){
        this.MemberId=MemberId;
        this.Barcode=Barcode;
    }
}