using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sandbox
{
	public class Enumerations
	{
		public enum MyEnum
		{
			[Description("Option 1")]
			Option1,
			[Description("Option 2")]
			Option2,
			[Description("Option 3")]
			Option3
		}

		public enum EventCode
		{
			//Provident Direct Website
			
			[XmlEnum("500")]
			SscRegistration = 500,
			
			[XmlEnum("501")]
			PasswordChanged = 501,
			
			[XmlEnum("502")]
			FailedLoginAttempt = 502,
			
			[XmlEnum("503")]
			AccountLocked = 503,
			
			[XmlEnum("504")]
			AbandonSession = 504,
			
			[XmlEnum("505")]
			PasswordReset = 505,
			
			[XmlEnum("506")]
			ChangeEmailAddress = 506,
			
			[XmlEnum("507")]
			LandsOnPricePresentationPage = 507,
			
			[XmlEnum("508")]
			QuoteLocked = 508,
			//Quote Services
			
			[XmlEnum("600")]
			CreatePersonTopX = 600,
			
			[XmlEnum("601")]
			CreatePersonClickThru = 601,
			
			[XmlEnum("602")]
			CreatePersonMajorNewQuoteConfirmation = 602,
			
			[XmlEnum("603")]
			AmendedQuoteConfirmed = 603,
			
			[XmlEnum("604")]
			ChangeVoluntaryExcess = 604,
			
			[XmlEnum("605")]
			QuoteSaved = 605,

			
			[XmlEnum("650")]
			RenewalQuote = 650,
			
			[XmlEnum("651")]
			RenewalDeclined = 651,
			
			[XmlEnum("655")]
			RenewalQuoteSaved = 655,
			
			[XmlEnum("680")]
			RenewalStatusChange = 680,
			
			[XmlEnum("681")]
			RenewalPaymentChange = 681,
			
			[XmlEnum("682")]
			RenewalAutoOn = 682,
			
			[XmlEnum("683")]
			RenewalAutoOff = 683,
			
			[XmlEnum("685")]
			RenewalQuoteExpiry = 685,

			//Communications Store 
			
			[XmlEnum("700")]
			NcbProofSupplied = 700,
			
			[XmlEnum("701")]
			DrivingLicenceSupplied = 701,

			//Customer Contact Centre – Landscape Transactions
			
			[XmlEnum("800")]
			NewPolicyPurchased = 800,
			//NewPolicyPurchasedWelcome = 801,
			
			[XmlEnum("801")]
			NcbProofChecked = 801,
			
			[XmlEnum("802")]
			DrivingLicenceChecked = 802,
			
			[XmlEnum("803")]
			GenerateOnlinePolicyDocuments = 803,
			
			[XmlEnum("804")]
			GenerateOfflinePolicyDocuments = 804,
			
			[XmlEnum("805")]
			MtaPurchased = 805,
			
			[XmlEnum("806")]
			MtaPurchasedAddOn = 806,
			
			[XmlEnum("807")]
			PolicyCancelled = 807,
			
			[XmlEnum("808")]
			PolicyProductCancelled = 808,
			
			[XmlEnum("809")]
			AccountDetailsChanged = 809,
			
			[XmlEnum("810")]
			ClaimDisclosed = 810,
			
			[XmlEnum("811")]
			ClientDetailAmendment = 811,
			
			[XmlEnum("813")]
			DocumentCheckMisMatch = 813,
			
			[XmlEnum("814")]
			PolicyCancelledCoolingOff = 814,
			
			[XmlEnum("815")]
			NcbRollback = 815,
			
			[XmlEnum("850")]
			RenewalAcceptance = 850,
			
			[XmlEnum("851")]
			RenewalAcceptanceDd = 851,
			
			[XmlEnum("852")]
			RenewalLapse = 852,

			//Customer Contact Centre – Landscape Payments
			
			[XmlEnum("900")]
			AuddisFailures = 900,
			
			[XmlEnum("901")]
			AddacsFailures = 901,
			
			[XmlEnum("902")]
			AruddFailures = 902,
			
			[XmlEnum("903")]
			PaymentReceiptConfirmation = 903,
			
			[XmlEnum("904")]
			BankAccountDetailsUpdated = 904,

			
			[XmlEnum("1000")]
			PitneyServiceCall = 1000

		}
	}
}
