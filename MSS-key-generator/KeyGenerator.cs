using System;

namespace MSS_key_generator;

public class KeyGenerator
{
    String[] myArr = new String[]
    {
        "DF", "BF"
    };
    
    //Activate, Deactivate, Delete, Put, Create - df actions
    
    //Activate, Deactivate, Delete, Read, Update, Write - bf actions

    //createTag-sizeTag-patternTag-sizeTag-sizeFileTag-sizeFileValue-typeFileTag-0101-

    public string generateCreateKey(string sizeValue, string nameValue, string accessValue)
    {
        return "";
        // string hexValue;
        //
        // string createTag = "00e0000";
        // string patternTag = "62"; 
        // string sizeTag = "80";
        // string fileTypeTagAndValue = "820101";
        // string fileNameTag = "83";
        // string stringOperationTag = "8606";
        //
        // string valueFrom80ToAccess =
        //     sizeTag +
        //     sizeValue +
        //     fileTypeTagAndValue +
        //     fileNameTag +
        //     findLengthInBytes()
        //
        // if (sizeTLV.Length < 9)
        // {
        //     hexValue = "0" + string.Format("{0:x}", sizeTLV);   
        // }
        // else
        // {
        //     hexValue = string.Format("{0:x}", sizeTLV);
        // }
        //     
        // sizeTLV = hexValue + sizeTLV;
        //
        // if (sizeTLV.Length < 9)
        // {
        //     hexValue = "0" + string.Format("{0:x}", sizeTLV);   
        // }
        // else
        // {
        //     hexValue = string.Format("{0:x}", sizeTLV);
        // }
        //
        // return createTag + hexValue + sizeTLV;
    }

    public string findHexValue(string value)
    {
        return "";
    }
    
    public string findLengthInBytes(string value)
    {
        // if()
        return "";
    }
}