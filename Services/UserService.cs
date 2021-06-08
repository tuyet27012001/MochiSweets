using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MochiSweets.Models;
using System.Security.Cryptography;
using System.Text;

namespace MochiSweets.Services
{
  public class UserService
  {
    private MyDbContext dbContext;
    public UserService(MyDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

     public string GetMd5Hash(MD5 md5Hash, string input)
    {

      // Convert the input string to a byte array and compute the hash.
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes
      // and create a string.
      StringBuilder sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data 
      // and format each one as a hexadecimal string.
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }

      // Return the hexadecimal string.
      return sBuilder.ToString();
    }

    public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
    {
      string hashOfInput = GetMd5Hash(md5Hash, input);

      StringComparer comparer = StringComparer.OrdinalIgnoreCase;

      if (0 == comparer.Compare(hashOfInput, hash))
      {
        return true;
      }
      else
      {
        return false;
      }
    }



    public bool AddCustomer(string userName, string customerName, string phonenumber,
        string gender, string birthDate,string email, string passwordCustomer){
      List<Customer> listCustomer = GetListCustomer();
      foreach(var cu in listCustomer){
        if(userName.Equals(cu.userName) || phonenumber.Equals(cu.phonenumber) ||
        email.Equals(cu.email)){
          return false;
        }
      }

      try
      {
        MD5 mD5 = MD5.Create();
        Customer req = new Customer();
        req.userName = userName;
        req.customerName = customerName;
        req.phonenumber = phonenumber;
        req.gender = gender;
        req.birthDate = birthDate;
        req.email = email;
        req.passwordCustomer = GetMd5Hash(mD5,passwordCustomer);
        dbContext.Add(req);
        dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error : " + ex.Message);
        return false;
      }
    }

    public Customer Login(string customerName , string passwordCustomer){
      MD5 md5Hash = MD5.Create();
      Customer ac = new Customer();
      ac = dbContext.Customer.FirstOrDefault(a => a.customerName == customerName);
      if(ac != null){
        if(VerifyMd5Hash(md5Hash, passwordCustomer, ac.passwordCustomer)){
          return ac;
        }
        else{
          return null;
        }
      }
      return null;
    }

    public List<Customer> GetListCustomer()
    {
      List<Customer> listCustomer = new List<Customer>();
      listCustomer = dbContext.Customer.ToList();
      return listCustomer;
    }
  } 
}