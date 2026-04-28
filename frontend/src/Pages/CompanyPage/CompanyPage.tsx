import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { getCompanyProfile } from "../../api";

interface Props {}

const CompanyPage = (props: Props) => {
  let { ticker } = useParams();

  const [company, setCompany] = useState<any>();

  useEffect(() => {
    const getProfileInit = async () => {
      try {
        // pega apenas o símbolo (remove o -EXCHANGE)
        const symbolOnly = ticker?.split("-")[0];

        const result = await getCompanyProfile(symbolOnly!);

        if (result) {
          setCompany(result.data);
        }
      } catch (error) {
        console.log("Erro ao buscar empresa:", error);
      }
    };

    getProfileInit();
  }, [ticker]);

  return (
    <>
      {company ? (
        <div className="company-profile-container p-6">
          <h1 className="text-2xl font-bold mb-4">
            {company.name} ({company.symbol})
          </h1>

          <p>
            <strong>Exchange:</strong> {company.exchange}
          </p>

          <p>
            <strong>Currency:</strong> {company.currency}
          </p>

          <p>
            <strong>Price:</strong> ${company.close}
          </p>
        </div>
      ) : (
        <div className="p-6">Company Not Found!</div>
      )}
    </>
  );
};

export default CompanyPage;