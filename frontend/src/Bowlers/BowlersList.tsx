import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlersList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5126/Bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <div>
      <div className="row">
        <h4 className="text-center">All the Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>BowlerLastName</th>
            <th>BowlerFirstName</th>
            <th>BowlerMiddleInit</th>
            <th>BowlerAddress</th>
            <th>BowlerCity</th>
            <th>BowlerState</th>
            <th>BowlerZip</th>
            <th>BowlerPhoneNumber</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlersList;
